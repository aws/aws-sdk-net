using System;
using System.Collections.Generic;
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
            #region to-get-information-about-a-bot-1494431724188

            var client = new AmazonLexModelBuildingServiceClient();
            var response = client.GetBot(new GetBotRequest 
            {
                Name = "DocOrderPizza",
                VersionOrAlias = "$LATEST"
            });

            string version = response.Version;
            string name = response.Name;
            Statement abortStatement = response.AbortStatement;
            string checksum = response.Checksum;
            bool childDirected = response.ChildDirected;
            Prompt clarificationPrompt = response.ClarificationPrompt;
            DateTime createdDate = response.CreatedDate;
            string description = response.Description;
            int idleSessionTTLInSeconds = response.IdleSessionTTLInSeconds;
            List<Intent> intents = response.Intents;
            DateTime lastUpdatedDate = response.LastUpdatedDate;
            string locale = response.Locale;
            string status = response.Status;

            #endregion
        }

        public void LexModelBuildingServiceGetBots()
        {
            #region to-get-a-list-of-bots-1494432220036

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
            #region to-get-a-information-about-an-intent-1494432574147

            var client = new AmazonLexModelBuildingServiceClient();
            var response = client.GetIntent(new GetIntentRequest 
            {
                Version = "$LATEST",
                Name = "DocOrderPizza"
            });

            string version = response.Version;
            string name = response.Name;
            string checksum = response.Checksum;
            Statement conclusionStatement = response.ConclusionStatement;
            Prompt confirmationPrompt = response.ConfirmationPrompt;
            DateTime createdDate = response.CreatedDate;
            string description = response.Description;
            FulfillmentActivity fulfillmentActivity = response.FulfillmentActivity;
            DateTime lastUpdatedDate = response.LastUpdatedDate;
            Statement rejectionStatement = response.RejectionStatement;
            List<string> sampleUtterances = response.SampleUtterances;
            List<Slot> slots = response.Slots;

            #endregion
        }

        public void LexModelBuildingServiceGetIntents()
        {
            #region to-get-a-list-of-intents-1494432416363

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
            #region to-get-information-about-a-slot-type-1494432961004

            var client = new AmazonLexModelBuildingServiceClient();
            var response = client.GetSlotType(new GetSlotTypeRequest 
            {
                Version = "$LATEST",
                Name = "DocPizzaCrustType"
            });

            string version = response.Version;
            string name = response.Name;
            string checksum = response.Checksum;
            DateTime createdDate = response.CreatedDate;
            string description = response.Description;
            List<EnumerationValue> enumerationValues = response.EnumerationValues;
            DateTime lastUpdatedDate = response.LastUpdatedDate;

            #endregion
        }

        public void LexModelBuildingServiceGetSlotTypes()
        {
            #region to-get-a-list-of-slot-types-1494432757458

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
            #region to-create-a-bot-1494360003886

            var client = new AmazonLexModelBuildingServiceClient();
            var response = client.PutBot(new PutBotRequest 
            {
                Name = "DocOrderPizzaBot",
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
                ProcessBehavior = "SAVE"
            });

            string version = response.Version;
            string name = response.Name;
            Statement abortStatement = response.AbortStatement;
            string checksum = response.Checksum;
            bool childDirected = response.ChildDirected;
            Prompt clarificationPrompt = response.ClarificationPrompt;
            DateTime createdDate = response.CreatedDate;
            string description = response.Description;
            int idleSessionTTLInSeconds = response.IdleSessionTTLInSeconds;
            List<Intent> intents = response.Intents;
            DateTime lastUpdatedDate = response.LastUpdatedDate;
            string locale = response.Locale;
            string status = response.Status;

            #endregion
        }

        public void LexModelBuildingServicePutIntent()
        {
            #region to-create-an-intent-1494358144659

            var client = new AmazonLexModelBuildingServiceClient();
            var response = client.PutIntent(new PutIntentRequest 
            {
                Name = "DocOrderPizza",
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
                        Name = "Type",
                        Description = "The type of pizza to order.",
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
                        Name = "Crust",
                        Description = "The type of pizza crust to order.",
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
                        Name = "Sauce",
                        Description = "The type of sauce to use on the pizza.",
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

            string version = response.Version;
            string name = response.Name;
            string checksum = response.Checksum;
            Statement conclusionStatement = response.ConclusionStatement;
            Prompt confirmationPrompt = response.ConfirmationPrompt;
            DateTime createdDate = response.CreatedDate;
            string description = response.Description;
            FulfillmentActivity fulfillmentActivity = response.FulfillmentActivity;
            DateTime lastUpdatedDate = response.LastUpdatedDate;
            Statement rejectionStatement = response.RejectionStatement;
            List<string> sampleUtterances = response.SampleUtterances;
            List<Slot> slots = response.Slots;

            #endregion
        }

        public void LexModelBuildingServicePutSlotType()
        {
            #region to-create-a-slot-type-1494357262258

            var client = new AmazonLexModelBuildingServiceClient();
            var response = client.PutSlotType(new PutSlotTypeRequest 
            {
                Name = "PizzaSauceType",
                Description = "Available pizza sauces",
                EnumerationValues = new List<EnumerationValue> {
                    new EnumerationValue { Value = "red" },
                    new EnumerationValue { Value = "white" }
                }
            });

            string version = response.Version;
            string name = response.Name;
            string checksum = response.Checksum;
            DateTime createdDate = response.CreatedDate;
            string description = response.Description;
            List<EnumerationValue> enumerationValues = response.EnumerationValues;
            DateTime lastUpdatedDate = response.LastUpdatedDate;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}