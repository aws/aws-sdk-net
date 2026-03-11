using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.B2bi;
using Amazon.B2bi.Model;

namespace AWSSDKDocSamples.Amazon.B2bi.Generated
{
    class B2biSamples : ISample
    {
        public void B2biCreateCapability()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.CreateCapability(new CreateCapabilityRequest 
            {
                Name = "b2biexample",
                Type = "edi",
                ClientToken = "foo",
                Configuration = new CapabilityConfiguration { Edi = new EdiConfiguration {
                    Type = new EdiType { X12Details = new X12Details {
                        Version = "VERSION_4010",
                        TransactionSet = "X12_110"
                    } },
                    InputLocation = new S3Location {
                        Key = "input/",
                        BucketName = "test-bucket"
                    },
                    OutputLocation = new S3Location {
                        Key = "output/",
                        BucketName = "test-bucket"
                    },
                    TransformerId = "tr-9a893cf536df4658b"
                } },
                InstructionsDocuments = new List<S3Location> {
                    new S3Location {
                        Key = "instructiondoc.txt",
                        BucketName = "test-bucket"
                    }
                },
                Tags = new List<Tag> {
                    new Tag {
                        Key = "capabilityKey1",
                        Value = "capabilityValue1"
                    }
                }
            });

            string name = response.Name;
            string type = response.Type;
            string capabilityArn = response.CapabilityArn;
            string capabilityId = response.CapabilityId;
            CapabilityConfiguration configuration = response.Configuration;
            DateTime createdAt = response.CreatedAt;
            List<S3Location> instructionsDocuments = response.InstructionsDocuments;

            #endregion
        }

        public void B2biCreatePartnership()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.CreatePartnership(new CreatePartnershipRequest 
            {
                Name = "b2bipartner",
                Capabilities = new List<string> {
                    "ca-963a8121e4fc4e348"
                },
                ClientToken = "foo",
                Email = "john@example.com",
                Phone = "5555555555",
                ProfileId = "p-60fbc37c87f04fce9",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "sampleKey1",
                        Value = "sampleValue1"
                    }
                }
            });

            string name = response.Name;
            List<string> capabilities = response.Capabilities;
            DateTime createdAt = response.CreatedAt;
            string email = response.Email;
            string partnershipArn = response.PartnershipArn;
            string partnershipId = response.PartnershipId;
            string phone = response.Phone;
            string profileId = response.ProfileId;
            string tradingPartnerId = response.TradingPartnerId;

            #endregion
        }

        public void B2biCreateProfile()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.CreateProfile(new CreateProfileRequest 
            {
                Name = "Shipping Profile",
                BusinessName = "John's Shipping",
                ClientToken = "foo",
                Email = "john@example.com",
                Logging = "ENABLED",
                Phone = "5555555555",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "sampleKey",
                        Value = "sampleValue"
                    }
                }
            });

            string name = response.Name;
            string businessName = response.BusinessName;
            DateTime createdAt = response.CreatedAt;
            string email = response.Email;
            string logGroupName = response.LogGroupName;
            string logging = response.Logging;
            string phone = response.Phone;
            string profileArn = response.ProfileArn;
            string profileId = response.ProfileId;

            #endregion
        }

        public void B2biCreateStarterMappingTemplate()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.CreateStarterMappingTemplate(new CreateStarterMappingTemplateRequest 
            {
                MappingType = "JSONATA",
                OutputSampleLocation = new S3Location {
                    Key = "output-sample-key",
                    BucketName = "output-sample-bucket"
                },
                TemplateDetails = new TemplateDetails { X12 = new X12Details {
                    Version = "VERSION_4010",
                    TransactionSet = "X12_110"
                } }
            });

            string mappingTemplate = response.MappingTemplate;

            #endregion
        }

        public void B2biCreateTransformer()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.CreateTransformer(new CreateTransformerRequest 
            {
                Name = "transformX12",
                ClientToken = "foo",
                InputConversion = new InputConversion {
                    AdvancedOptions = new AdvancedOptions { X12 = new X12AdvancedOptions {
                        SplitOptions = new X12SplitOptions { SplitBy = "NONE" },
                        ValidationOptions = new X12ValidationOptions { ValidationRules = new List<X12ValidationRule> {
                            new X12ValidationRule { CodeListValidationRule = new X12CodeListValidationRule {
                                CodesToAdd = new List<string> {
                                    "A",
                                    "B",
                                    "C"
                                },
                                CodesToRemove = new List<string> {
                                    "X",
                                    "Y",
                                    "Z"
                                },
                                ElementId = "1234"
                            } },
                            new X12ValidationRule { ElementRequirementValidationRule = new X12ElementRequirementValidationRule {
                                ElementPosition = "NM1-01",
                                Requirement = "MANDATORY"
                            } },
                            new X12ValidationRule { ElementLengthValidationRule = new X12ElementLengthValidationRule {
                                ElementId = "5678",
                                MaxLength = 10,
                                MinLength = 2
                            } }
                        } }
                    } },
                    FormatOptions = new FormatOptions { X12 = new X12Details {
                        Version = "VERSION_4010",
                        TransactionSet = "X12_110"
                    } },
                    FromFormat = "X12"
                },
                Mapping = new Mapping {
                    Template = "{}",
                    TemplateLanguage = "JSONATA"
                },
                SampleDocuments = new SampleDocuments {
                    BucketName = "test-bucket",
                    Keys = new List<SampleDocumentKeys> {
                        new SampleDocumentKeys { Input = "sampleDoc.txt" }
                    }
                },
                Tags = new List<Tag> {
                    new Tag {
                        Key = "sampleKey",
                        Value = "sampleValue"
                    }
                }
            });

            string name = response.Name;
            DateTime createdAt = response.CreatedAt;
            InputConversion inputConversion = response.InputConversion;
            Mapping mapping = response.Mapping;
            SampleDocuments sampleDocuments = response.SampleDocuments;
            string status = response.Status;
            string transformerArn = response.TransformerArn;
            string transformerId = response.TransformerId;

            #endregion
        }

        public void B2biDeleteCapability()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.DeleteCapability(new DeleteCapabilityRequest 
            {
                CapabilityId = "ca-963a8121e4fc4e348"
            });


            #endregion
        }

        public void B2biDeletePartnership()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.DeletePartnership(new DeletePartnershipRequest 
            {
                PartnershipId = "ps-219fa02f5b4242af8"
            });


            #endregion
        }

        public void B2biDeleteProfile()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.DeleteProfile(new DeleteProfileRequest 
            {
                ProfileId = "p-60fbc37c87f04fce9"
            });


            #endregion
        }

        public void B2biDeleteTransformer()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.DeleteTransformer(new DeleteTransformerRequest 
            {
                TransformerId = "tr-974c129999f84d8c9"
            });


            #endregion
        }

        public void B2biGenerateMapping()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.GenerateMapping(new GenerateMappingRequest 
            {
                InputFileContent = "Sample input file content",
                MappingType = "JSONATA",
                OutputFileContent = "Sample output file content"
            });

            float mappingAccuracy = response.MappingAccuracy;
            string mappingTemplate = response.MappingTemplate;

            #endregion
        }

        public void B2biGetCapability()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.GetCapability(new GetCapabilityRequest 
            {
                CapabilityId = "ca-963a8121e4fc4e348"
            });

            string name = response.Name;
            string type = response.Type;
            string capabilityArn = response.CapabilityArn;
            string capabilityId = response.CapabilityId;
            CapabilityConfiguration configuration = response.Configuration;
            DateTime createdAt = response.CreatedAt;
            List<S3Location> instructionsDocuments = response.InstructionsDocuments;
            DateTime modifiedAt = response.ModifiedAt;

            #endregion
        }

        public void B2biGetPartnership()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.GetPartnership(new GetPartnershipRequest 
            {
                PartnershipId = "ps-219fa02f5b4242af8"
            });

            string name = response.Name;
            List<string> capabilities = response.Capabilities;
            DateTime createdAt = response.CreatedAt;
            string email = response.Email;
            DateTime modifiedAt = response.ModifiedAt;
            string partnershipArn = response.PartnershipArn;
            string partnershipId = response.PartnershipId;
            string phone = response.Phone;
            string profileId = response.ProfileId;
            string tradingPartnerId = response.TradingPartnerId;

            #endregion
        }

        public void B2biGetProfile()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.GetProfile(new GetProfileRequest 
            {
                ProfileId = "p-60fbc37c87f04fce9"
            });

            string name = response.Name;
            string businessName = response.BusinessName;
            DateTime createdAt = response.CreatedAt;
            string email = response.Email;
            string logGroupName = response.LogGroupName;
            string logging = response.Logging;
            string phone = response.Phone;
            string profileArn = response.ProfileArn;
            string profileId = response.ProfileId;

            #endregion
        }

        public void B2biGetTransformer()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.GetTransformer(new GetTransformerRequest 
            {
                TransformerId = "tr-974c129999f84d8c9"
            });

            string name = response.Name;
            DateTime createdAt = response.CreatedAt;
            InputConversion inputConversion = response.InputConversion;
            Mapping mapping = response.Mapping;
            SampleDocuments sampleDocuments = response.SampleDocuments;
            string status = response.Status;
            string transformerArn = response.TransformerArn;
            string transformerId = response.TransformerId;

            #endregion
        }

        public void B2biGetTransformerJob()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.GetTransformerJob(new GetTransformerJobRequest 
            {
                TransformerId = "tr-974c129999f84d8c9",
                TransformerJobId = "tj-vpYxfV7yQOqjMSYllEslLw"
            });

            string message = response.Message;
            List<S3Location> outputFiles = response.OutputFiles;
            string status = response.Status;

            #endregion
        }

        public void B2biListCapabilities()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.ListCapabilities(new ListCapabilitiesRequest 
            {
                MaxResults = 50,
                NextToken = "foo"
            });

            List<CapabilitySummary> capabilities = response.Capabilities;
            string nextToken = response.NextToken;

            #endregion
        }

        public void B2biListPartnerships()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.ListPartnerships(new ListPartnershipsRequest 
            {
                MaxResults = 50,
                NextToken = "foo",
                ProfileId = "p-60fbc37c87f04fce9"
            });

            string nextToken = response.NextToken;
            List<PartnershipSummary> partnerships = response.Partnerships;

            #endregion
        }

        public void B2biListProfiles()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.ListProfiles(new ListProfilesRequest 
            {
                MaxResults = 50,
                NextToken = "foo"
            });

            string nextToken = response.NextToken;
            List<ProfileSummary> profiles = response.Profiles;

            #endregion
        }

        public void B2biListTagsForResource()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceARN = "arn:aws:b2bi:us-west-2:123456789012:profile/p-60fbc37c87f04fce9"
            });

            List<Tag> tags = response.Tags;

            #endregion
        }

        public void B2biListTransformers()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.ListTransformers(new ListTransformersRequest 
            {
                MaxResults = 50,
                NextToken = "foo"
            });

            string nextToken = response.NextToken;
            List<TransformerSummary> transformers = response.Transformers;

            #endregion
        }

        public void B2biStartTransformerJob()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.StartTransformerJob(new StartTransformerJobRequest 
            {
                ClientToken = "foo",
                InputFile = new S3Location {
                    Key = "input/inputFile.txt",
                    BucketName = "test-bucket"
                },
                OutputLocation = new S3Location {
                    Key = "output/",
                    BucketName = "test-bucket"
                },
                TransformerId = "tr-974c129999f84d8c9"
            });

            string transformerJobId = response.TransformerJobId;

            #endregion
        }

        public void B2biTagResource()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceARN = "arn:aws:b2bi:us-west-2:123456789012:profile/p-60fbc37c87f04fce9",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "sampleKey",
                        Value = "SampleValue"
                    }
                }
            });


            #endregion
        }

        public void B2biTestConversion()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.TestConversion(new TestConversionRequest 
            {
                Source = new ConversionSource {
                    FileFormat = "JSON",
                    InputFile = new InputFileSource { FileContent = "Sample file content" }
                },
                Target = new ConversionTarget {
                    AdvancedOptions = new AdvancedOptions { X12 = new X12AdvancedOptions { ValidationOptions = new X12ValidationOptions { ValidationRules = new List<X12ValidationRule> {
                        new X12ValidationRule { CodeListValidationRule = new X12CodeListValidationRule {
                            CodesToAdd = new List<string> {
                                "X",
                                "Y",
                                "Z"
                            },
                            CodesToRemove = new List<string> {
                                "A",
                                "B",
                                "C"
                            },
                            ElementId = "1280"
                        } },
                        new X12ValidationRule { ElementRequirementValidationRule = new X12ElementRequirementValidationRule {
                            ElementPosition = "NM1-01",
                            Requirement = "OPTIONAL"
                        } },
                        new X12ValidationRule { ElementLengthValidationRule = new X12ElementLengthValidationRule {
                            ElementId = "0803",
                            MaxLength = 30,
                            MinLength = 5
                        } }
                    } } } },
                    FileFormat = "X12",
                    FormatDetails = new ConversionTargetFormatDetails { X12 = new X12Details {
                        Version = "VERSION_4010",
                        TransactionSet = "X12_110"
                    } }
                }
            });

            string convertedFileContent = response.ConvertedFileContent;
            List<string> validationMessages = response.ValidationMessages;

            #endregion
        }

        public void B2biTestMapping()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.TestMapping(new TestMappingRequest 
            {
                FileFormat = "JSON",
                InputFileContent = "Sample file content",
                MappingTemplate = "$"
            });

            string mappedFileContent = response.MappedFileContent;

            #endregion
        }

        public void B2biTestParsing()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.TestParsing(new TestParsingRequest 
            {
                EdiType = new EdiType { X12Details = new X12Details {
                    Version = "VERSION_4010",
                    TransactionSet = "X12_110"
                } },
                FileFormat = "JSON",
                InputFile = new S3Location {
                    Key = "sampleFile.txt",
                    BucketName = "test-bucket"
                }
            });

            string parsedFileContent = response.ParsedFileContent;

            #endregion
        }

        public void B2biTestParsing()
        {
            #region example-2

            var client = new AmazonB2biClient();
            var response = client.TestParsing(new TestParsingRequest 
            {
                AdvancedOptions = new AdvancedOptions { X12 = new X12AdvancedOptions { SplitOptions = new X12SplitOptions { SplitBy = "NONE" } } },
                EdiType = new EdiType { X12Details = new X12Details {
                    Version = "VERSION_4010",
                    TransactionSet = "X12_110"
                } },
                FileFormat = "JSON",
                InputFile = new S3Location {
                    Key = "sampleFile.txt",
                    BucketName = "test-bucket"
                }
            });

            string parsedFileContent = response.ParsedFileContent;

            #endregion
        }

        public void B2biTestParsing()
        {
            #region example-3

            var client = new AmazonB2biClient();
            var response = client.TestParsing(new TestParsingRequest 
            {
                AdvancedOptions = new AdvancedOptions { X12 = new X12AdvancedOptions { SplitOptions = new X12SplitOptions { SplitBy = "TRANSACTION" } } },
                EdiType = new EdiType { X12Details = new X12Details {
                    Version = "VERSION_4010",
                    TransactionSet = "X12_110"
                } },
                FileFormat = "JSON",
                InputFile = new S3Location {
                    Key = "sampleFile.txt",
                    BucketName = "test-bucket"
                }
            });

            string parsedFileContent = response.ParsedFileContent;
            List<string> parsedSplitFileContents = response.ParsedSplitFileContents;

            #endregion
        }

        public void B2biTestParsing()
        {
            #region example-4

            var client = new AmazonB2biClient();
            var response = client.TestParsing(new TestParsingRequest 
            {
                AdvancedOptions = new AdvancedOptions { X12 = new X12AdvancedOptions { ValidationOptions = new X12ValidationOptions { ValidationRules = new List<X12ValidationRule> {
                    new X12ValidationRule { CodeListValidationRule = new X12CodeListValidationRule {
                        CodesToAdd = new List<string> {
                            "X",
                            "Y",
                            "Z"
                        },
                        CodesToRemove = new List<string> {
                            "A",
                            "B",
                            "C"
                        },
                        ElementId = "1280"
                    } },
                    new X12ValidationRule { ElementRequirementValidationRule = new X12ElementRequirementValidationRule {
                        ElementPosition = "NM1-01",
                        Requirement = "OPTIONAL"
                    } },
                    new X12ValidationRule { ElementLengthValidationRule = new X12ElementLengthValidationRule {
                        ElementId = "0803",
                        MaxLength = 30,
                        MinLength = 5
                    } }
                } } } },
                EdiType = new EdiType { X12Details = new X12Details {
                    Version = "VERSION_4010",
                    TransactionSet = "X12_110"
                } },
                FileFormat = "JSON",
                InputFile = new S3Location {
                    Key = "sampleFile.txt",
                    BucketName = "test-bucket"
                }
            });

            string parsedFileContent = response.ParsedFileContent;
            List<string> parsedSplitFileContents = response.ParsedSplitFileContents;

            #endregion
        }

        public void B2biUntagResource()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceARN = "arn:aws:b2bi:us-west-2:123456789012:profile/p-60fbc37c87f04fce9",
                TagKeys = new List<string> {
                    "sampleKey"
                }
            });


            #endregion
        }

        public void B2biUpdateCapability()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.UpdateCapability(new UpdateCapabilityRequest 
            {
                Name = "b2biexample",
                CapabilityId = "ca-963a8121e4fc4e348",
                Configuration = new CapabilityConfiguration { Edi = new EdiConfiguration {
                    Type = new EdiType { X12Details = new X12Details {
                        Version = "VERSION_4010",
                        TransactionSet = "X12_110"
                    } },
                    InputLocation = new S3Location {
                        Key = "input/",
                        BucketName = "test-bucket"
                    },
                    OutputLocation = new S3Location {
                        Key = "output/",
                        BucketName = "test-bucket"
                    },
                    TransformerId = "tr-9a893cf536df4658b"
                } },
                InstructionsDocuments = new List<S3Location> {
                    new S3Location {
                        Key = "instructiondoc.txt",
                        BucketName = "test-bucket"
                    }
                }
            });

            string name = response.Name;
            string type = response.Type;
            string capabilityArn = response.CapabilityArn;
            string capabilityId = response.CapabilityId;
            CapabilityConfiguration configuration = response.Configuration;
            DateTime createdAt = response.CreatedAt;
            List<S3Location> instructionsDocuments = response.InstructionsDocuments;
            DateTime modifiedAt = response.ModifiedAt;

            #endregion
        }

        public void B2biUpdatePartnership()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.UpdatePartnership(new UpdatePartnershipRequest 
            {
                Name = "b2bipartner",
                Capabilities = new List<string> {
                    "ca-963a8121e4fc4e348"
                },
                PartnershipId = "ps-219fa02f5b4242af8"
            });

            string name = response.Name;
            List<string> capabilities = response.Capabilities;
            DateTime createdAt = response.CreatedAt;
            string email = response.Email;
            DateTime modifiedAt = response.ModifiedAt;
            string partnershipArn = response.PartnershipArn;
            string partnershipId = response.PartnershipId;
            string phone = response.Phone;
            string profileId = response.ProfileId;
            string tradingPartnerId = response.TradingPartnerId;

            #endregion
        }

        public void B2biUpdateProfile()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.UpdateProfile(new UpdateProfileRequest 
            {
                Name = "Shipping Profile",
                BusinessName = "John's Shipping",
                Email = "john@example.com",
                Phone = "5555555555",
                ProfileId = "p-60fbc37c87f04fce9"
            });

            string name = response.Name;
            string businessName = response.BusinessName;
            DateTime createdAt = response.CreatedAt;
            string email = response.Email;
            string logGroupName = response.LogGroupName;
            string logging = response.Logging;
            DateTime modifiedAt = response.ModifiedAt;
            string phone = response.Phone;
            string profileArn = response.ProfileArn;
            string profileId = response.ProfileId;

            #endregion
        }

        public void B2biUpdateTransformer()
        {
            #region example-1

            var client = new AmazonB2biClient();
            var response = client.UpdateTransformer(new UpdateTransformerRequest 
            {
                Name = "transformX12",
                InputConversion = new InputConversion {
                    AdvancedOptions = new AdvancedOptions { X12 = new X12AdvancedOptions {
                        SplitOptions = new X12SplitOptions { SplitBy = "NONE" },
                        ValidationOptions = new X12ValidationOptions { ValidationRules = new List<X12ValidationRule> {
                            new X12ValidationRule { CodeListValidationRule = new X12CodeListValidationRule {
                                CodesToAdd = new List<string> {
                                    "A",
                                    "B",
                                    "C"
                                },
                                CodesToRemove = new List<string> {
                                    "X",
                                    "Y",
                                    "Z"
                                },
                                ElementId = "1234"
                            } },
                            new X12ValidationRule { ElementRequirementValidationRule = new X12ElementRequirementValidationRule {
                                ElementPosition = "NM1-01",
                                Requirement = "MANDATORY"
                            } },
                            new X12ValidationRule { ElementLengthValidationRule = new X12ElementLengthValidationRule {
                                ElementId = "5678",
                                MaxLength = 10,
                                MinLength = 2
                            } }
                        } }
                    } },
                    FormatOptions = new FormatOptions { X12 = new X12Details {
                        Version = "VERSION_4010",
                        TransactionSet = "X12_110"
                    } },
                    FromFormat = "X12"
                },
                Mapping = new Mapping {
                    Template = "{}",
                    TemplateLanguage = "JSONATA"
                },
                SampleDocuments = new SampleDocuments {
                    BucketName = "test-bucket",
                    Keys = new List<SampleDocumentKeys> {
                        new SampleDocumentKeys { Input = "sampleDoc.txt" }
                    }
                },
                Status = "inactive",
                TransformerId = "tr-974c129999f84d8c9"
            });

            string name = response.Name;
            DateTime createdAt = response.CreatedAt;
            InputConversion inputConversion = response.InputConversion;
            Mapping mapping = response.Mapping;
            DateTime modifiedAt = response.ModifiedAt;
            SampleDocuments sampleDocuments = response.SampleDocuments;
            string status = response.Status;
            string transformerArn = response.TransformerArn;
            string transformerId = response.TransformerId;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}