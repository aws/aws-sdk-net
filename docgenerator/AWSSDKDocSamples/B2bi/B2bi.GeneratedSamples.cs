using System;
using System.Collections.Generic;
using System.IO;
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
            #region CreateCapability-1

            var client = new AmazonB2biClient();
            var response = client.CreateCapability(new CreateCapabilityRequest
            {
                ClientToken = "foo",
                Configuration = new CapabilityConfiguration { Edi = new EdiConfiguration {
                    InputLocation = new S3Location {
                        BucketName = "test-bucket",
                        Key = "input/"
                    },
                    OutputLocation = new S3Location {
                        BucketName = "test-bucket",
                        Key = "output/"
                    },
                    TransformerId = "tr-9a893cf536df4658b",
                    Type = new EdiType { X12Details = new X12Details {
                        TransactionSet = "X12_110",
                        Version = "VERSION_4010"
                    } }
                } },
                InstructionsDocuments = new List<S3Location> {
                    new S3Location {
                        BucketName = "test-bucket",
                        Key = "instructiondoc.txt"
                    }
                },
                Name = "b2biexample",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "capabilityKey1",
                        Value = "capabilityValue1"
                    }
                },
                Type = "edi"
            });

            string capabilityArn = response.CapabilityArn;
            string capabilityId = response.CapabilityId;
            CapabilityConfiguration configuration = response.Configuration;
            DateTime? createdAt = response.CreatedAt;
            List<S3Location> instructionsDocuments = response.InstructionsDocuments;
            string name = response.Name;
            CapabilityType type = response.Type;

            #endregion
        }

        public void B2biCreatePartnership()
        {
            #region CreatePartnership-1

            var client = new AmazonB2biClient();
            var response = client.CreatePartnership(new CreatePartnershipRequest
            {
                Capabilities = new List<string> {
                    "ca-963a8121e4fc4e348"
                },
                ClientToken = "foo",
                Email = "john@example.com",
                Name = "b2bipartner",
                Phone = "5555555555",
                ProfileId = "p-60fbc37c87f04fce9",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "sampleKey1",
                        Value = "sampleValue1"
                    }
                }
            });

            List<string> capabilities = response.Capabilities;
            DateTime? createdAt = response.CreatedAt;
            string email = response.Email;
            string name = response.Name;
            string partnershipArn = response.PartnershipArn;
            string partnershipId = response.PartnershipId;
            string phone = response.Phone;
            string profileId = response.ProfileId;
            string tradingPartnerId = response.TradingPartnerId;

            #endregion
        }

        public void B2biCreateProfile()
        {
            #region CreateProfile-1

            var client = new AmazonB2biClient();
            var response = client.CreateProfile(new CreateProfileRequest
            {
                BusinessName = "John's Shipping",
                ClientToken = "foo",
                Email = "john@example.com",
                Logging = "ENABLED",
                Name = "Shipping Profile",
                Phone = "5555555555",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "sampleKey",
                        Value = "sampleValue"
                    }
                }
            });

            string businessName = response.BusinessName;
            DateTime? createdAt = response.CreatedAt;
            string email = response.Email;
            string logGroupName = response.LogGroupName;
            Logging logging = response.Logging;
            string name = response.Name;
            string phone = response.Phone;
            string profileArn = response.ProfileArn;
            string profileId = response.ProfileId;

            #endregion
        }

        public void B2biCreateStarterMappingTemplate()
        {
            #region CreateStarterMappingTemplate-1

            var client = new AmazonB2biClient();
            var response = client.CreateStarterMappingTemplate(new CreateStarterMappingTemplateRequest
            {
                MappingType = "JSONATA",
                OutputSampleLocation = new S3Location {
                    BucketName = "output-sample-bucket",
                    Key = "output-sample-key"
                },
                TemplateDetails = new TemplateDetails { X12 = new X12Details {
                    TransactionSet = "X12_110",
                    Version = "VERSION_4010"
                } }
            });

            string mappingTemplate = response.MappingTemplate;

            #endregion
        }

        public void B2biCreateTransformer()
        {
            #region CreateTransformer-1

            var client = new AmazonB2biClient();
            var response = client.CreateTransformer(new CreateTransformerRequest
            {
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
                        TransactionSet = "X12_110",
                        Version = "VERSION_4010"
                    } },
                    FromFormat = "X12"
                },
                Mapping = new Mapping {
                    Template = "{}",
                    TemplateLanguage = "JSONATA"
                },
                Name = "transformX12",
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

            DateTime? createdAt = response.CreatedAt;
            InputConversion inputConversion = response.InputConversion;
            Mapping mapping = response.Mapping;
            string name = response.Name;
            SampleDocuments sampleDocuments = response.SampleDocuments;
            TransformerStatus status = response.Status;
            string transformerArn = response.TransformerArn;
            string transformerId = response.TransformerId;

            #endregion
        }

        public void B2biDeleteCapability()
        {
            #region DeleteCapability-1

            var client = new AmazonB2biClient();
            var response = client.DeleteCapability(new DeleteCapabilityRequest
            {
                CapabilityId = "ca-963a8121e4fc4e348"
            });


            #endregion
        }

        public void B2biDeletePartnership()
        {
            #region DeletePartnership-1

            var client = new AmazonB2biClient();
            var response = client.DeletePartnership(new DeletePartnershipRequest
            {
                PartnershipId = "ps-219fa02f5b4242af8"
            });


            #endregion
        }

        public void B2biDeleteProfile()
        {
            #region DeleteProfile-1

            var client = new AmazonB2biClient();
            var response = client.DeleteProfile(new DeleteProfileRequest
            {
                ProfileId = "p-60fbc37c87f04fce9"
            });


            #endregion
        }

        public void B2biDeleteTransformer()
        {
            #region DeleteTransformer-1

            var client = new AmazonB2biClient();
            var response = client.DeleteTransformer(new DeleteTransformerRequest
            {
                TransformerId = "tr-974c129999f84d8c9"
            });


            #endregion
        }

        public void B2biGenerateMapping()
        {
            #region GenerateMapping-1

            var client = new AmazonB2biClient();
            var response = client.GenerateMapping(new GenerateMappingRequest
            {
                InputFileContent = "Sample input file content",
                MappingType = "JSONATA",
                OutputFileContent = "Sample output file content"
            });

            float? mappingAccuracy = response.MappingAccuracy;
            string mappingTemplate = response.MappingTemplate;

            #endregion
        }

        public void B2biGetCapability()
        {
            #region GetCapability-1

            var client = new AmazonB2biClient();
            var response = client.GetCapability(new GetCapabilityRequest
            {
                CapabilityId = "ca-963a8121e4fc4e348"
            });

            string capabilityArn = response.CapabilityArn;
            string capabilityId = response.CapabilityId;
            CapabilityConfiguration configuration = response.Configuration;
            DateTime? createdAt = response.CreatedAt;
            List<S3Location> instructionsDocuments = response.InstructionsDocuments;
            DateTime? modifiedAt = response.ModifiedAt;
            string name = response.Name;
            CapabilityType type = response.Type;

            #endregion
        }

        public void B2biGetPartnership()
        {
            #region GetPartnership-1

            var client = new AmazonB2biClient();
            var response = client.GetPartnership(new GetPartnershipRequest
            {
                PartnershipId = "ps-219fa02f5b4242af8"
            });

            List<string> capabilities = response.Capabilities;
            DateTime? createdAt = response.CreatedAt;
            string email = response.Email;
            DateTime? modifiedAt = response.ModifiedAt;
            string name = response.Name;
            string partnershipArn = response.PartnershipArn;
            string partnershipId = response.PartnershipId;
            string phone = response.Phone;
            string profileId = response.ProfileId;
            string tradingPartnerId = response.TradingPartnerId;

            #endregion
        }

        public void B2biGetProfile()
        {
            #region GetProfile-1

            var client = new AmazonB2biClient();
            var response = client.GetProfile(new GetProfileRequest
            {
                ProfileId = "p-60fbc37c87f04fce9"
            });

            string businessName = response.BusinessName;
            DateTime? createdAt = response.CreatedAt;
            string email = response.Email;
            string logGroupName = response.LogGroupName;
            Logging logging = response.Logging;
            string name = response.Name;
            string phone = response.Phone;
            string profileArn = response.ProfileArn;
            string profileId = response.ProfileId;

            #endregion
        }

        public void B2biGetTransformer()
        {
            #region GetTransformer-1

            var client = new AmazonB2biClient();
            var response = client.GetTransformer(new GetTransformerRequest
            {
                TransformerId = "tr-974c129999f84d8c9"
            });

            DateTime? createdAt = response.CreatedAt;
            InputConversion inputConversion = response.InputConversion;
            Mapping mapping = response.Mapping;
            string name = response.Name;
            SampleDocuments sampleDocuments = response.SampleDocuments;
            TransformerStatus status = response.Status;
            string transformerArn = response.TransformerArn;
            string transformerId = response.TransformerId;

            #endregion
        }

        public void B2biGetTransformerJob()
        {
            #region GetTransformerJob-1

            var client = new AmazonB2biClient();
            var response = client.GetTransformerJob(new GetTransformerJobRequest
            {
                TransformerId = "tr-974c129999f84d8c9",
                TransformerJobId = "tj-vpYxfV7yQOqjMSYllEslLw"
            });

            string message = response.Message;
            List<S3Location> outputFiles = response.OutputFiles;
            TransformerJobStatus status = response.Status;

            #endregion
        }

        public void B2biListCapabilities()
        {
            #region ListCapabilities-1

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
            #region ListPartnerships-1

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
            #region ListProfiles-1

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
            #region ListTagsForResource-1

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
            #region ListTransformers-1

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
            #region StartTransformerJob-1

            var client = new AmazonB2biClient();
            var response = client.StartTransformerJob(new StartTransformerJobRequest
            {
                ClientToken = "foo",
                InputFile = new S3Location {
                    BucketName = "test-bucket",
                    Key = "input/inputFile.txt"
                },
                OutputLocation = new S3Location {
                    BucketName = "test-bucket",
                    Key = "output/"
                },
                TransformerId = "tr-974c129999f84d8c9"
            });

            string transformerJobId = response.TransformerJobId;

            #endregion
        }

        public void B2biTagResource()
        {
            #region TagResource-1

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
            #region TestConversion-1

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
                        TransactionSet = "X12_110",
                        Version = "VERSION_4010"
                    } }
                }
            });

            string convertedFileContent = response.ConvertedFileContent;
            List<string> validationMessages = response.ValidationMessages;

            #endregion
        }

        public void B2biTestMapping()
        {
            #region TestMapping-1

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
            #region TestParsing-1

            var client = new AmazonB2biClient();
            var response = client.TestParsing(new TestParsingRequest
            {
                EdiType = new EdiType { X12Details = new X12Details {
                    TransactionSet = "X12_110",
                    Version = "VERSION_4010"
                } },
                FileFormat = "JSON",
                InputFile = new S3Location {
                    BucketName = "test-bucket",
                    Key = "sampleFile.txt"
                }
            });

            string parsedFileContent = response.ParsedFileContent;

            #endregion
        }

        public void B2biTestParsing()
        {
            #region TestParsing-2

            var client = new AmazonB2biClient();
            var response = client.TestParsing(new TestParsingRequest
            {
                AdvancedOptions = new AdvancedOptions { X12 = new X12AdvancedOptions { SplitOptions = new X12SplitOptions { SplitBy = "NONE" } } },
                EdiType = new EdiType { X12Details = new X12Details {
                    TransactionSet = "X12_110",
                    Version = "VERSION_4010"
                } },
                FileFormat = "JSON",
                InputFile = new S3Location {
                    BucketName = "test-bucket",
                    Key = "sampleFile.txt"
                }
            });

            string parsedFileContent = response.ParsedFileContent;

            #endregion
        }

        public void B2biTestParsing()
        {
            #region TestParsing-3

            var client = new AmazonB2biClient();
            var response = client.TestParsing(new TestParsingRequest
            {
                AdvancedOptions = new AdvancedOptions { X12 = new X12AdvancedOptions { SplitOptions = new X12SplitOptions { SplitBy = "TRANSACTION" } } },
                EdiType = new EdiType { X12Details = new X12Details {
                    TransactionSet = "X12_110",
                    Version = "VERSION_4010"
                } },
                FileFormat = "JSON",
                InputFile = new S3Location {
                    BucketName = "test-bucket",
                    Key = "sampleFile.txt"
                }
            });

            string parsedFileContent = response.ParsedFileContent;
            List<string> parsedSplitFileContents = response.ParsedSplitFileContents;

            #endregion
        }

        public void B2biTestParsing()
        {
            #region TestParsing-4

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
                    TransactionSet = "X12_110",
                    Version = "VERSION_4010"
                } },
                FileFormat = "JSON",
                InputFile = new S3Location {
                    BucketName = "test-bucket",
                    Key = "sampleFile.txt"
                }
            });

            string parsedFileContent = response.ParsedFileContent;
            List<string> parsedSplitFileContents = response.ParsedSplitFileContents;

            #endregion
        }

        public void B2biUntagResource()
        {
            #region UntagResource-1

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
            #region UpdateCapability-1

            var client = new AmazonB2biClient();
            var response = client.UpdateCapability(new UpdateCapabilityRequest
            {
                CapabilityId = "ca-963a8121e4fc4e348",
                Configuration = new CapabilityConfiguration { Edi = new EdiConfiguration {
                    InputLocation = new S3Location {
                        BucketName = "test-bucket",
                        Key = "input/"
                    },
                    OutputLocation = new S3Location {
                        BucketName = "test-bucket",
                        Key = "output/"
                    },
                    TransformerId = "tr-9a893cf536df4658b",
                    Type = new EdiType { X12Details = new X12Details {
                        TransactionSet = "X12_110",
                        Version = "VERSION_4010"
                    } }
                } },
                InstructionsDocuments = new List<S3Location> {
                    new S3Location {
                        BucketName = "test-bucket",
                        Key = "instructiondoc.txt"
                    }
                },
                Name = "b2biexample"
            });

            string capabilityArn = response.CapabilityArn;
            string capabilityId = response.CapabilityId;
            CapabilityConfiguration configuration = response.Configuration;
            DateTime? createdAt = response.CreatedAt;
            List<S3Location> instructionsDocuments = response.InstructionsDocuments;
            DateTime? modifiedAt = response.ModifiedAt;
            string name = response.Name;
            CapabilityType type = response.Type;

            #endregion
        }

        public void B2biUpdatePartnership()
        {
            #region UpdatePartnership-1

            var client = new AmazonB2biClient();
            var response = client.UpdatePartnership(new UpdatePartnershipRequest
            {
                Capabilities = new List<string> {
                    "ca-963a8121e4fc4e348"
                },
                Name = "b2bipartner",
                PartnershipId = "ps-219fa02f5b4242af8"
            });

            List<string> capabilities = response.Capabilities;
            DateTime? createdAt = response.CreatedAt;
            string email = response.Email;
            DateTime? modifiedAt = response.ModifiedAt;
            string name = response.Name;
            string partnershipArn = response.PartnershipArn;
            string partnershipId = response.PartnershipId;
            string phone = response.Phone;
            string profileId = response.ProfileId;
            string tradingPartnerId = response.TradingPartnerId;

            #endregion
        }

        public void B2biUpdateProfile()
        {
            #region UpdateProfile-1

            var client = new AmazonB2biClient();
            var response = client.UpdateProfile(new UpdateProfileRequest
            {
                BusinessName = "John's Shipping",
                Email = "john@example.com",
                Name = "Shipping Profile",
                Phone = "5555555555",
                ProfileId = "p-60fbc37c87f04fce9"
            });

            string businessName = response.BusinessName;
            DateTime? createdAt = response.CreatedAt;
            string email = response.Email;
            string logGroupName = response.LogGroupName;
            Logging logging = response.Logging;
            DateTime? modifiedAt = response.ModifiedAt;
            string name = response.Name;
            string phone = response.Phone;
            string profileArn = response.ProfileArn;
            string profileId = response.ProfileId;

            #endregion
        }

        public void B2biUpdateTransformer()
        {
            #region UpdateTransformer-1

            var client = new AmazonB2biClient();
            var response = client.UpdateTransformer(new UpdateTransformerRequest
            {
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
                        TransactionSet = "X12_110",
                        Version = "VERSION_4010"
                    } },
                    FromFormat = "X12"
                },
                Mapping = new Mapping {
                    Template = "{}",
                    TemplateLanguage = "JSONATA"
                },
                Name = "transformX12",
                SampleDocuments = new SampleDocuments {
                    BucketName = "test-bucket",
                    Keys = new List<SampleDocumentKeys> {
                        new SampleDocumentKeys { Input = "sampleDoc.txt" }
                    }
                },
                Status = "inactive",
                TransformerId = "tr-974c129999f84d8c9"
            });

            DateTime? createdAt = response.CreatedAt;
            InputConversion inputConversion = response.InputConversion;
            Mapping mapping = response.Mapping;
            DateTime? modifiedAt = response.ModifiedAt;
            string name = response.Name;
            SampleDocuments sampleDocuments = response.SampleDocuments;
            TransformerStatus status = response.Status;
            string transformerArn = response.TransformerArn;
            string transformerId = response.TransformerId;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
