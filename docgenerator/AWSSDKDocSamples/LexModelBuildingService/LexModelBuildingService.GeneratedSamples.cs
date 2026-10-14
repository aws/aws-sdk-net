using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.LexModelBuildingService;
using Amazon.LexModelBuildingService.Model;

namespace AWSSDKDocSamples.Amazon.LexModelBuildingService.Generated
{
    class LexModelBuildingServiceSamples : ISample
    {
        public void LexModelBuildingServiceGetBot()
        {
            #region GetBot-1

            var client = new AmazonLexModelBuildingServiceClient();
            var response = client.GetBot(new GetBotRequest
            {
                Name = "DocOrderPizza",
                VersionOrAlias = "$LATEST"
            });

            Statement abortStatement = response.AbortStatement;
            string checksum = response.Checksum;
            bool? childDirected = response.ChildDirected;
            Prompt clarificationPrompt = response.ClarificationPrompt;
            DateTime? createdDate = response.CreatedDate;
            string description = response.Description;
            int? idleSessionTTLInSeconds = response.IdleSessionTTLInSeconds;
            List<Intent> intents = response.Intents;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            Locale locale = response.Locale;
            string name = response.Name;
            Status status = response.Status;
            string version = response.Version;

            #endregion
        }

        public void LexModelBuildingServiceGetBots()
        {
            #region GetBots-1

            var client = new AmazonLexModelBuildingServiceClient();
            var response = client.GetBots(new GetBotsRequest
            {
                MaxResults = 5,
                NextToken = ""
            });

            List<BotMetadata> bots = response.Bots;

            #endregion
        }

        public void LexModelBuildingServiceGetIntent()
        {
            #region GetIntent-1

            var client = new AmazonLexModelBuildingServiceClient();
            var response = client.GetIntent(new GetIntentRequest
            {
                Name = "DocOrderPizza",
                Version = "$LATEST"
            });

            string checksum = response.Checksum;
            Statement conclusionStatement = response.ConclusionStatement;
            Prompt confirmationPrompt = response.ConfirmationPrompt;
            DateTime? createdDate = response.CreatedDate;
            string description = response.Description;
            FulfillmentActivity fulfillmentActivity = response.FulfillmentActivity;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string name = response.Name;
            Statement rejectionStatement = response.RejectionStatement;
            List<string> sampleUtterances = response.SampleUtterances;
            List<Slot> slots = response.Slots;
            string version = response.Version;

            #endregion
        }

        public void LexModelBuildingServiceGetIntents()
        {
            #region GetIntents-1

            var client = new AmazonLexModelBuildingServiceClient();
            var response = client.GetIntents(new GetIntentsRequest
            {
                MaxResults = 10,
                NextToken = ""
            });

            List<IntentMetadata> intents = response.Intents;

            #endregion
        }

        public void LexModelBuildingServiceGetSlotType()
        {
            #region GetSlotType-1

            var client = new AmazonLexModelBuildingServiceClient();
            var response = client.GetSlotType(new GetSlotTypeRequest
            {
                Name = "DocPizzaCrustType",
                Version = "$LATEST"
            });

            string checksum = response.Checksum;
            DateTime? createdDate = response.CreatedDate;
            string description = response.Description;
            List<EnumerationValue> enumerationValues = response.EnumerationValues;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string name = response.Name;
            string version = response.Version;

            #endregion
        }

        public void LexModelBuildingServiceGetSlotTypes()
        {
            #region GetSlotTypes-1

            var client = new AmazonLexModelBuildingServiceClient();
            var response = client.GetSlotTypes(new GetSlotTypesRequest
            {
                MaxResults = 10,
                NextToken = ""
            });

            List<SlotTypeMetadata> slotTypes = response.SlotTypes;

            #endregion
        }

        public void LexModelBuildingServicePutBot()
        {
            #region PutBot-1

            var client = new AmazonLexModelBuildingServiceClient();
            var response = client.PutBot(new PutBotRequest
            {
                AbortStatement = new Statement { Messages = new List<Message> {
                    new Message {
                        Content = "I don't understand. Can you try again?",
                        ContentType = "PlainText"
                    },
                    new Message {
                        Content = "I'm sorry, I don't understand.",
                        ContentType = "PlainText"
                    }
                } },
                ChildDirected = true,
                ClarificationPrompt = new Prompt {
                    MaxAttempts = 1,
                    Messages = new List<Message> {
                        new Message {
                            Content = "I'm sorry, I didn't hear that. Can you repeat what you just said?",
                            ContentType = "PlainText"
                        },
                        new Message {
                            Content = "Can you say that again?",
                            ContentType = "PlainText"
                        }
                    }
                },
                Description = "Orders a pizza from a local pizzeria.",
                IdleSessionTTLInSeconds = 300,
                Intents = new List<Intent> {
                    new Intent {
                        IntentName = "DocOrderPizza",
                        IntentVersion = "$LATEST"
                    }
                },
                Locale = "en-US",
                Name = "DocOrderPizzaBot",
                ProcessBehavior = "SAVE"
            });

            Statement abortStatement = response.AbortStatement;
            string checksum = response.Checksum;
            bool? childDirected = response.ChildDirected;
            Prompt clarificationPrompt = response.ClarificationPrompt;
            DateTime? createdDate = response.CreatedDate;
            string description = response.Description;
            int? idleSessionTTLInSeconds = response.IdleSessionTTLInSeconds;
            List<Intent> intents = response.Intents;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            Locale locale = response.Locale;
            string name = response.Name;
            Status status = response.Status;
            string version = response.Version;

            #endregion
        }

        public void LexModelBuildingServicePutIntent()
        {
            #region PutIntent-1

            var client = new AmazonLexModelBuildingServiceClient();
            var response = client.PutIntent(new PutIntentRequest
            {
                ConclusionStatement = new Statement {
                    Messages = new List<Message> {
                        new Message {
                            Content = "All right, I ordered  you a {Crust} crust {Type} pizza with {Sauce} sauce.",
                            ContentType = "PlainText"
                        },
                        new Message {
                            Content = "OK, your {Crust} crust {Type} pizza with {Sauce} sauce is on the way.",
                            ContentType = "PlainText"
                        }
                    },
                    ResponseCard = "foo"
                },
                ConfirmationPrompt = new Prompt {
                    MaxAttempts = 1,
                    Messages = new List<Message> {
                        new Message {
                            Content = "Should I order  your {Crust} crust {Type} pizza with {Sauce} sauce?",
                            ContentType = "PlainText"
                        }
                    }
                },
                Description = "Order a pizza from a local pizzeria.",
                FulfillmentActivity = new FulfillmentActivity { Type = "ReturnIntent" },
                Name = "DocOrderPizza",
                RejectionStatement = new Statement { Messages = new List<Message> {
                    new Message {
                        Content = "Ok, I'll cancel your order.",
                        ContentType = "PlainText"
                    },
                    new Message {
                        Content = "I cancelled your order.",
                        ContentType = "PlainText"
                    }
                } },
                SampleUtterances = new List<string> {
                    "Order me a pizza.",
                    "Order me a {Type} pizza.",
                    "I want a {Crust} crust {Type} pizza",
                    "I want a {Crust} crust {Type} pizza with {Sauce} sauce."
                },
                Slots = new List<Slot> {
                    new Slot {
                        Description = "The type of pizza to order.",
                        Name = "Type",
                        Priority = 1,
                        SampleUtterances = new List<string> {
                            "Get me a {Type} pizza.",
                            "A {Type} pizza please.",
                            "I'd like a {Type} pizza."
                        },
                        SlotConstraint = "Required",
                        SlotType = "DocPizzaType",
                        SlotTypeVersion = "$LATEST",
                        ValueElicitationPrompt = new Prompt {
                            MaxAttempts = 1,
                            Messages = new List<Message> {
                                new Message {
                                    Content = "What type of pizza would you like?",
                                    ContentType = "PlainText"
                                },
                                new Message {
                                    Content = "Vegie or cheese pizza?",
                                    ContentType = "PlainText"
                                },
                                new Message {
                                    Content = "I can get you a vegie or a cheese pizza.",
                                    ContentType = "PlainText"
                                }
                            }
                        }
                    },
                    new Slot {
                        Description = "The type of pizza crust to order.",
                        Name = "Crust",
                        Priority = 2,
                        SampleUtterances = new List<string> {
                            "Make it a {Crust} crust.",
                            "I'd like a {Crust} crust."
                        },
                        SlotConstraint = "Required",
                        SlotType = "DocPizzaCrustType",
                        SlotTypeVersion = "$LATEST",
                        ValueElicitationPrompt = new Prompt {
                            MaxAttempts = 1,
                            Messages = new List<Message> {
                                new Message {
                                    Content = "What type of crust would you like?",
                                    ContentType = "PlainText"
                                },
                                new Message {
                                    Content = "Thick or thin crust?",
                                    ContentType = "PlainText"
                                }
                            }
                        }
                    },
                    new Slot {
                        Description = "The type of sauce to use on the pizza.",
                        Name = "Sauce",
                        Priority = 3,
                        SampleUtterances = new List<string> {
                            "Make it {Sauce} sauce.",
                            "I'd like {Sauce} sauce."
                        },
                        SlotConstraint = "Required",
                        SlotType = "DocPizzaSauceType",
                        SlotTypeVersion = "$LATEST",
                        ValueElicitationPrompt = new Prompt {
                            MaxAttempts = 1,
                            Messages = new List<Message> {
                                new Message {
                                    Content = "White or red sauce?",
                                    ContentType = "PlainText"
                                },
                                new Message {
                                    Content = "Garlic or tomato sauce?",
                                    ContentType = "PlainText"
                                }
                            }
                        }
                    }
                }
            });

            string checksum = response.Checksum;
            Statement conclusionStatement = response.ConclusionStatement;
            Prompt confirmationPrompt = response.ConfirmationPrompt;
            DateTime? createdDate = response.CreatedDate;
            string description = response.Description;
            FulfillmentActivity fulfillmentActivity = response.FulfillmentActivity;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string name = response.Name;
            Statement rejectionStatement = response.RejectionStatement;
            List<string> sampleUtterances = response.SampleUtterances;
            List<Slot> slots = response.Slots;
            string version = response.Version;

            #endregion
        }

        public void LexModelBuildingServicePutSlotType()
        {
            #region PutSlotType-1

            var client = new AmazonLexModelBuildingServiceClient();
            var response = client.PutSlotType(new PutSlotTypeRequest
            {
                Description = "Available pizza sauces",
                EnumerationValues = new List<EnumerationValue> {
                    new EnumerationValue { Value = "red" },
                    new EnumerationValue { Value = "white" }
                },
                Name = "PizzaSauceType"
            });

            string checksum = response.Checksum;
            DateTime? createdDate = response.CreatedDate;
            string description = response.Description;
            List<EnumerationValue> enumerationValues = response.EnumerationValues;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string name = response.Name;
            string version = response.Version;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
