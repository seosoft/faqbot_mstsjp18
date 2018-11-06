// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License

using System.Collections.Generic;
using Microsoft.Bot.Builder.AI.QnA;
using Microsoft.Bot.Configuration;

namespace Microsoft.BotBuilderSamples
{
    /// <summary>
    /// Represents references to external services.
    /// </summary>
    /// <seealso cref="https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.1"/>
    /// <seealso cref="https://www.luis.ai/home"/>
    public class BotServices
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BotServices"/> class.
        /// </summary>
        public BotServices(BotConfiguration botConfiguration)
        {
            foreach (var service in botConfiguration.Services)
            {
                switch (service.Type)
                {
                    case ServiceTypes.QnA:
                        {
                        var qna = service as QnAMakerService;
                        var qnaEndpoint = new QnAMakerEndpoint()
                        {
                            KnowledgeBaseId = qna.KbId,
                            EndpointKey = qna.EndpointKey,
                            Host = qna.Hostname,
                        };
                        var qnaMaker = new QnAMaker(qnaEndpoint);
                        QnAServices.Add(qna.Id, qnaMaker);
                        break;
                    }
                }
            }
        }

        public Dictionary<string, QnAMaker> QnAServices { get; } = new Dictionary<string, QnAMaker>();
    }
}
