using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.MediaPackageV2;
using Amazon.MediaPackageV2.Model;

namespace AWSSDKDocSamples.Amazon.MediaPackageV2.Generated
{
    class MediaPackageV2Samples : ISample
    {
        public void MediaPackageV2CancelHarvestJob()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.CancelHarvestJob(new CancelHarvestJobRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannelName",
                HarvestJobName = "HarvestJobName",
                OriginEndpointName = "exampleOriginEndpointName"
            });


            #endregion
        }

        public void MediaPackageV2CreateChannel()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.CreateChannel(new CreateChannelRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel",
                Description = "Description for exampleChannel",
                InputType = "HLS",
                Tags = new Dictionary<string, string> {
                    { "key1", "value1" },
                    { "key2", "value2" }
                }
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string eTag = response.ETag;
            List<IngestEndpoint> ingestEndpoints = response.IngestEndpoints;
            string inputType = response.InputType;
            DateTime modifiedAt = response.ModifiedAt;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MediaPackageV2CreateChannelGroup()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.CreateChannelGroup(new CreateChannelGroupRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                Description = "Description for exampleChannelGroup",
                Tags = new Dictionary<string, string> {
                    { "key1", "value1" },
                    { "key2", "value2" }
                }
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string eTag = response.ETag;
            string egressDomain = response.EgressDomain;
            DateTime modifiedAt = response.ModifiedAt;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MediaPackageV2CreateHarvestJob()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.CreateHarvestJob(new CreateHarvestJobRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannelName",
                Description = "Example HarvestJob description",
                Destination = new Destination { S3Destination = new S3DestinationConfig {
                    BucketName = "harvestJobS3DestinationBucket",
                    DestinationPath = "manifests"
                } },
                HarvestedManifests = new HarvestedManifests {
                    DashManifests = new List<HarvestedDashManifest> {
                        new HarvestedDashManifest { ManifestName = "DashManifest" }
                    },
                    HlsManifests = new List<HarvestedHlsManifest> {
                        new HarvestedHlsManifest { ManifestName = "HlsManifest" }
                    },
                    LowLatencyHlsManifests = new List<HarvestedLowLatencyHlsManifest> {
                        new HarvestedLowLatencyHlsManifest { ManifestName = "LowLatencyHlsManifest" }
                    }
                },
                OriginEndpointName = "exampleOriginEndpointName",
                ScheduleConfiguration = new HarvesterScheduleConfiguration {
                    EndTime = new DateTime(2024, 5, 28, 12, 0, 0, DateTimeKind.Utc),
                    StartTime = new DateTime(2024, 5, 28, 6, 0, 0, DateTimeKind.Utc)
                }
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            Destination destination = response.Destination;
            string eTag = response.ETag;
            string harvestJobName = response.HarvestJobName;
            HarvestedManifests harvestedManifests = response.HarvestedManifests;
            DateTime modifiedAt = response.ModifiedAt;
            string originEndpointName = response.OriginEndpointName;
            HarvesterScheduleConfiguration scheduleConfiguration = response.ScheduleConfiguration;
            string status = response.Status;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MediaPackageV2CreateOriginEndpoint()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.CreateOriginEndpoint(new CreateOriginEndpointRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel",
                ContainerType = "TS",
                Description = "Description for exampleOriginEndpointTS",
                ForceEndpointErrorConfiguration = new ForceEndpointErrorConfiguration { EndpointErrorConditions = new List<string> {
                    "STALE_MANIFEST",
                    "INCOMPLETE_MANIFEST",
                    "MISSING_DRM_KEY",
                    "SLATE_INPUT"
                } },
                HlsManifests = new List<CreateHlsManifestConfiguration> {
                    new CreateHlsManifestConfiguration {
                        ChildManifestName = "exampleChildManifest1",
                        ManifestName = "exampleManifest1",
                        ManifestWindowSeconds = 30,
                        ProgramDateTimeIntervalSeconds = 60,
                        ScteHls = new ScteHls { AdMarkerHls = "DATERANGE" }
                    },
                    new CreateHlsManifestConfiguration {
                        ChildManifestName = "exampleManifest2",
                        ManifestName = "exampleManifest2",
                        ManifestWindowSeconds = 30,
                        ProgramDateTimeIntervalSeconds = 60,
                        ScteHls = new ScteHls { AdMarkerHls = "DATERANGE" }
                    }
                },
                LowLatencyHlsManifests = new List<CreateLowLatencyHlsManifestConfiguration> {
                    new CreateLowLatencyHlsManifestConfiguration {
                        ChildManifestName = "exampleLLChildManifest1",
                        ManifestName = "exampleLLManifest1",
                        ManifestWindowSeconds = 30,
                        ProgramDateTimeIntervalSeconds = 60,
                        ScteHls = new ScteHls { AdMarkerHls = "DATERANGE" }
                    },
                    new CreateLowLatencyHlsManifestConfiguration {
                        ChildManifestName = "exampleLLManifest2",
                        ManifestName = "exampleLLManifest2",
                        ManifestWindowSeconds = 30,
                        ProgramDateTimeIntervalSeconds = 60,
                        ScteHls = new ScteHls { AdMarkerHls = "DATERANGE" }
                    }
                },
                OriginEndpointName = "exampleOriginEndpointTS",
                Segment = new Segment {
                    Encryption = new Encryption {
                        ConstantInitializationVector = "A382A901F3C1F7718512266CFFBB0B7E",
                        EncryptionMethod = new EncryptionMethod { TsEncryptionMethod = "AES_128" },
                        KeyRotationIntervalSeconds = 300,
                        SpekeKeyProvider = new SpekeKeyProvider {
                            DrmSystems = new List<string> {
                                "CLEAR_KEY_AES_128"
                            },
                            EncryptionContractConfiguration = new EncryptionContractConfiguration {
                                PresetSpeke20Audio = "SHARED",
                                PresetSpeke20Video = "SHARED"
                            },
                            ResourceId = "ResourceId",
                            RoleArn = "arn:aws:iam::123456789012:role/empRole",
                            Url = "https://foo.com"
                        }
                    },
                    IncludeIframeOnlyStreams = true,
                    Scte = new Scte { ScteFilter = new List<string> {
                        "SPLICE_INSERT",
                        "BREAK"
                    } },
                    SegmentDurationSeconds = 6,
                    SegmentName = "segmentName",
                    TsIncludeDvbSubtitles = true,
                    TsUseAudioRenditionGroup = true
                },
                StartoverWindowSeconds = 300,
                Tags = new Dictionary<string, string> {
                    { "key1", "value1" },
                    { "key2", "value2" }
                }
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            string containerType = response.ContainerType;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string eTag = response.ETag;
            ForceEndpointErrorConfiguration forceEndpointErrorConfiguration = response.ForceEndpointErrorConfiguration;
            List<GetHlsManifestConfiguration> hlsManifests = response.HlsManifests;
            List<GetLowLatencyHlsManifestConfiguration> lowLatencyHlsManifests = response.LowLatencyHlsManifests;
            DateTime modifiedAt = response.ModifiedAt;
            string originEndpointName = response.OriginEndpointName;
            Segment segment = response.Segment;
            int startoverWindowSeconds = response.StartoverWindowSeconds;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MediaPackageV2CreateOriginEndpoint()
        {
            #region example-2

            var client = new AmazonMediaPackageV2Client();
            var response = client.CreateOriginEndpoint(new CreateOriginEndpointRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel",
                ContainerType = "CMAF",
                DashManifests = new List<CreateDashManifestConfiguration> {
                    new CreateDashManifestConfiguration {
                        BaseUrls = new List<DashBaseUrl> {
                            new DashBaseUrl {
                                DvbPriority = 1,
                                DvbWeight = 3,
                                ServiceLocation = "A",
                                Url = "http://example.com/"
                            }
                        },
                        Compactness = "STANDARD",
                        DrmSignaling = "INDIVIDUAL",
                        DvbSettings = new DashDvbSettings {
                            ErrorMetrics = new List<DashDvbMetricsReporting> {
                                new DashDvbMetricsReporting {
                                    Probability = 500,
                                    ReportingUrl = "https://example.com/dvb-errors/errors"
                                }
                            },
                            FontDownload = new DashDvbFontDownload {
                                FontFamily = "SubtitleDisplay",
                                MimeType = "application/font",
                                Url = "https://example.com/fonts/SubtitleDisplay.woff"
                            }
                        },
                        ManifestName = "exampleDashManifest1",
                        ManifestWindowSeconds = 300,
                        MinBufferTimeSeconds = 30,
                        MinUpdatePeriodSeconds = 5,
                        PeriodTriggers = new List<string> {
                            "AVAILS"
                        },
                        Profiles = new List<string> {
                            "DVB_DASH"
                        },
                        ProgramInformation = new DashProgramInformation {
                            Copyright = "(c) Example. All rights reserved",
                            LanguageCode = "en",
                            MoreInformationUrl = "https://example.com/more-information",
                            Source = "exampleSource",
                            Title = "exampleTitle"
                        },
                        ScteDash = new ScteDash { AdMarkerDash = "XML" },
                        SegmentTemplateFormat = "NUMBER_WITH_TIMELINE",
                        SuggestedPresentationDelaySeconds = 2,
                        UtcTiming = new DashUtcTiming {
                            TimingMode = "HTTP_HEAD",
                            TimingSource = "example"
                        }
                    },
                    new CreateDashManifestConfiguration {
                        BaseUrls = new List<DashBaseUrl> {
                            new DashBaseUrl {
                                DvbPriority = 2,
                                DvbWeight = 2,
                                ServiceLocation = "B",
                                Url = "http://example2.com/"
                            }
                        },
                        Compactness = "STANDARD",
                        DrmSignaling = "INDIVIDUAL",
                        DvbSettings = new DashDvbSettings {
                            ErrorMetrics = new List<DashDvbMetricsReporting> {
                                new DashDvbMetricsReporting {
                                    Probability = 600,
                                    ReportingUrl = "https://example2.com/dvb-errors/errors"
                                }
                            },
                            FontDownload = new DashDvbFontDownload {
                                FontFamily = "SubtitleDisplay",
                                MimeType = "application/font",
                                Url = "https://example.com/fonts/SubtitleDisplay.woff"
                            }
                        },
                        ManifestName = "exampleDashManifest2",
                        ManifestWindowSeconds = 60,
                        MinBufferTimeSeconds = 9,
                        MinUpdatePeriodSeconds = 3,
                        PeriodTriggers = new List<string> {
                            "AVAILS",
                            "DRM_KEY_ROTATION",
                            "SOURCE_CHANGES",
                            "SOURCE_DISRUPTIONS"
                        },
                        Profiles = new List<string> {
                            "DVB_DASH"
                        },
                        ProgramInformation = new DashProgramInformation {
                            Copyright = "(c) Example. All rights reserved",
                            LanguageCode = "en",
                            MoreInformationUrl = "https://example2.com/more-information",
                            Source = "exampleSource2",
                            Title = "exampleTitle2"
                        },
                        ScteDash = new ScteDash { AdMarkerDash = "XML" },
                        SegmentTemplateFormat = "NUMBER_WITH_TIMELINE",
                        SuggestedPresentationDelaySeconds = 12,
                        UtcTiming = new DashUtcTiming {
                            TimingMode = "HTTP_HEAD",
                            TimingSource = "example"
                        }
                    }
                },
                ForceEndpointErrorConfiguration = new ForceEndpointErrorConfiguration { EndpointErrorConditions = new List<string> {
                    "STALE_MANIFEST",
                    "INCOMPLETE_MANIFEST",
                    "MISSING_DRM_KEY",
                    "SLATE_INPUT"
                } },
                HlsManifests = new List<CreateHlsManifestConfiguration> {
                    new CreateHlsManifestConfiguration {
                        ChildManifestName = "exampleChildManifest1",
                        ManifestName = "exampleManifest1",
                        ManifestWindowSeconds = 30,
                        ProgramDateTimeIntervalSeconds = 60,
                        ScteHls = new ScteHls { AdMarkerHls = "DATERANGE" }
                    },
                    new CreateHlsManifestConfiguration {
                        ChildManifestName = "exampleManifest2",
                        ManifestName = "exampleManifest2",
                        ManifestWindowSeconds = 30,
                        ProgramDateTimeIntervalSeconds = 60,
                        ScteHls = new ScteHls { AdMarkerHls = "DATERANGE" }
                    }
                },
                LowLatencyHlsManifests = new List<CreateLowLatencyHlsManifestConfiguration> {
                    new CreateLowLatencyHlsManifestConfiguration {
                        ChildManifestName = "exampleLLChildManifest1",
                        ManifestName = "exampleLLManifest1",
                        ManifestWindowSeconds = 30,
                        ProgramDateTimeIntervalSeconds = 60,
                        ScteHls = new ScteHls { AdMarkerHls = "DATERANGE" }
                    },
                    new CreateLowLatencyHlsManifestConfiguration {
                        ChildManifestName = "exampleLLManifest2",
                        ManifestName = "exampleLLManifest2",
                        ManifestWindowSeconds = 30,
                        ProgramDateTimeIntervalSeconds = 60,
                        ScteHls = new ScteHls { AdMarkerHls = "DATERANGE" }
                    }
                },
                OriginEndpointName = "exampleOriginEndpointCMAF",
                Segment = new Segment {
                    Encryption = new Encryption {
                        ConstantInitializationVector = "A382A901F3C1F7718512266CFFBB0B9F",
                        EncryptionMethod = new EncryptionMethod { CmafEncryptionMethod = "CBCS" },
                        KeyRotationIntervalSeconds = 300,
                        SpekeKeyProvider = new SpekeKeyProvider {
                            DrmSystems = new List<string> {
                                "PLAYREADY",
                                "WIDEVINE"
                            },
                            EncryptionContractConfiguration = new EncryptionContractConfiguration {
                                PresetSpeke20Audio = "PRESET_AUDIO_1",
                                PresetSpeke20Video = "PRESET_VIDEO_1"
                            },
                            ResourceId = "ResourceId",
                            RoleArn = "arn:aws:iam::123456789012:role/empRole",
                            Url = "https://foo.com"
                        }
                    },
                    IncludeIframeOnlyStreams = true,
                    Scte = new Scte { ScteFilter = new List<string> {
                        "SPLICE_INSERT",
                        "BREAK"
                    } },
                    SegmentDurationSeconds = 6,
                    SegmentName = "segmentName"
                },
                StartoverWindowSeconds = 300,
                Tags = new Dictionary<string, string> {
                    { "key1", "value1" },
                    { "key2", "value2" }
                }
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            string containerType = response.ContainerType;
            DateTime createdAt = response.CreatedAt;
            List<GetDashManifestConfiguration> dashManifests = response.DashManifests;
            string eTag = response.ETag;
            ForceEndpointErrorConfiguration forceEndpointErrorConfiguration = response.ForceEndpointErrorConfiguration;
            List<GetHlsManifestConfiguration> hlsManifests = response.HlsManifests;
            List<GetLowLatencyHlsManifestConfiguration> lowLatencyHlsManifests = response.LowLatencyHlsManifests;
            DateTime modifiedAt = response.ModifiedAt;
            string originEndpointName = response.OriginEndpointName;
            Segment segment = response.Segment;
            int startoverWindowSeconds = response.StartoverWindowSeconds;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MediaPackageV2CreateOriginEndpoint()
        {
            #region example-3

            var client = new AmazonMediaPackageV2Client();
            var response = client.CreateOriginEndpoint(new CreateOriginEndpointRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel",
                ContainerType = "ISM",
                Description = "Description for exampleOriginEndpointISM",
                ForceEndpointErrorConfiguration = new ForceEndpointErrorConfiguration { EndpointErrorConditions = new List<string> {
                    "STALE_MANIFEST",
                    "INCOMPLETE_MANIFEST",
                    "MISSING_DRM_KEY",
                    "SLATE_INPUT"
                } },
                MssManifests = new List<CreateMssManifestConfiguration> {
                    new CreateMssManifestConfiguration {
                        ManifestLayout = "FULL",
                        ManifestName = "exampleMssManifest1",
                        ManifestWindowSeconds = 60
                    }
                },
                OriginEndpointName = "exampleOriginEndpointISM",
                Segment = new Segment {
                    Encryption = new Encryption {
                        EncryptionMethod = new EncryptionMethod { IsmEncryptionMethod = "CENC" },
                        SpekeKeyProvider = new SpekeKeyProvider {
                            DrmSystems = new List<string> {
                                "PLAYREADY"
                            },
                            EncryptionContractConfiguration = new EncryptionContractConfiguration {
                                PresetSpeke20Audio = "SHARED",
                                PresetSpeke20Video = "SHARED"
                            },
                            ResourceId = "ResourceId",
                            RoleArn = "arn:aws:iam::123456789012:role/empRole",
                            Url = "https://speke-key-provider.example.com"
                        }
                    },
                    SegmentDurationSeconds = 2,
                    SegmentName = "segmentName"
                },
                StartoverWindowSeconds = 300,
                Tags = new Dictionary<string, string> {
                    { "key1", "value1" },
                    { "key2", "value2" }
                }
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            string containerType = response.ContainerType;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string eTag = response.ETag;
            ForceEndpointErrorConfiguration forceEndpointErrorConfiguration = response.ForceEndpointErrorConfiguration;
            DateTime modifiedAt = response.ModifiedAt;
            List<GetMssManifestConfiguration> mssManifests = response.MssManifests;
            string originEndpointName = response.OriginEndpointName;
            Segment segment = response.Segment;
            int startoverWindowSeconds = response.StartoverWindowSeconds;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MediaPackageV2DeleteChannel()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.DeleteChannel(new DeleteChannelRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel"
            });


            #endregion
        }

        public void MediaPackageV2DeleteChannelGroup()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.DeleteChannelGroup(new DeleteChannelGroupRequest 
            {
                ChannelGroupName = "exampleChannelGroup"
            });


            #endregion
        }

        public void MediaPackageV2DeleteChannelPolicy()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.DeleteChannelPolicy(new DeleteChannelPolicyRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel"
            });


            #endregion
        }

        public void MediaPackageV2DeleteOriginEndpoint()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.DeleteOriginEndpoint(new DeleteOriginEndpointRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel",
                OriginEndpointName = "exampleOriginEndpointTS"
            });


            #endregion
        }

        public void MediaPackageV2DeleteOriginEndpointPolicy()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.DeleteOriginEndpointPolicy(new DeleteOriginEndpointPolicyRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel",
                OriginEndpointName = "exampleOriginEndpoint"
            });


            #endregion
        }

        public void MediaPackageV2GetChannel()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.GetChannel(new GetChannelRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel"
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string eTag = response.ETag;
            List<IngestEndpoint> ingestEndpoints = response.IngestEndpoints;
            string inputType = response.InputType;
            DateTime modifiedAt = response.ModifiedAt;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MediaPackageV2GetChannelGroup()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.GetChannelGroup(new GetChannelGroupRequest 
            {
                ChannelGroupName = "exampleChannelGroup"
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string eTag = response.ETag;
            string egressDomain = response.EgressDomain;
            DateTime modifiedAt = response.ModifiedAt;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MediaPackageV2GetChannelPolicy()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.GetChannelPolicy(new GetChannelPolicyRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel"
            });

            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            string policy = response.Policy;

            #endregion
        }

        public void MediaPackageV2GetHarvestJob()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.GetHarvestJob(new GetHarvestJobRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannelName",
                HarvestJobName = "HarvestJobName",
                OriginEndpointName = "exampleOriginEndpointName"
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            Destination destination = response.Destination;
            string eTag = response.ETag;
            string harvestJobName = response.HarvestJobName;
            HarvestedManifests harvestedManifests = response.HarvestedManifests;
            DateTime modifiedAt = response.ModifiedAt;
            string originEndpointName = response.OriginEndpointName;
            HarvesterScheduleConfiguration scheduleConfiguration = response.ScheduleConfiguration;
            string status = response.Status;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MediaPackageV2GetOriginEndpoint()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.GetOriginEndpoint(new GetOriginEndpointRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel",
                OriginEndpointName = "exampleOriginEndpointTS"
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            string containerType = response.ContainerType;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string eTag = response.ETag;
            ForceEndpointErrorConfiguration forceEndpointErrorConfiguration = response.ForceEndpointErrorConfiguration;
            List<GetHlsManifestConfiguration> hlsManifests = response.HlsManifests;
            List<GetLowLatencyHlsManifestConfiguration> lowLatencyHlsManifests = response.LowLatencyHlsManifests;
            DateTime modifiedAt = response.ModifiedAt;
            string originEndpointName = response.OriginEndpointName;
            Segment segment = response.Segment;
            int startoverWindowSeconds = response.StartoverWindowSeconds;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MediaPackageV2GetOriginEndpoint()
        {
            #region example-2

            var client = new AmazonMediaPackageV2Client();
            var response = client.GetOriginEndpoint(new GetOriginEndpointRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel",
                OriginEndpointName = "exampleOriginEndpointISM"
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            string containerType = response.ContainerType;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string eTag = response.ETag;
            ForceEndpointErrorConfiguration forceEndpointErrorConfiguration = response.ForceEndpointErrorConfiguration;
            DateTime modifiedAt = response.ModifiedAt;
            List<GetMssManifestConfiguration> mssManifests = response.MssManifests;
            string originEndpointName = response.OriginEndpointName;
            Segment segment = response.Segment;
            int startoverWindowSeconds = response.StartoverWindowSeconds;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MediaPackageV2GetOriginEndpointPolicy()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.GetOriginEndpointPolicy(new GetOriginEndpointPolicyRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel",
                OriginEndpointName = "exampleOriginEndpoint"
            });

            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            string originEndpointName = response.OriginEndpointName;
            string policy = response.Policy;

            #endregion
        }

        public void MediaPackageV2ListChannelGroups()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.ListChannelGroups(new ListChannelGroupsRequest 
            {
            });

            List<ChannelGroupListConfiguration> items = response.Items;

            #endregion
        }

        public void MediaPackageV2ListChannels()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.ListChannels(new ListChannelsRequest 
            {
                ChannelGroupName = "exampleChannelGroup"
            });

            List<ChannelListConfiguration> items = response.Items;

            #endregion
        }

        public void MediaPackageV2ListHarvestJobs()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.ListHarvestJobs(new ListHarvestJobsRequest 
            {
                ChannelGroupName = "exampleChannelGroup"
            });

            List<HarvestJob> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MediaPackageV2ListHarvestJobs()
        {
            #region example-2

            var client = new AmazonMediaPackageV2Client();
            var response = client.ListHarvestJobs(new ListHarvestJobsRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannelName"
            });

            List<HarvestJob> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MediaPackageV2ListHarvestJobs()
        {
            #region example-3

            var client = new AmazonMediaPackageV2Client();
            var response = client.ListHarvestJobs(new ListHarvestJobsRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannelName",
                OriginEndpointName = "exampleOriginEndpointName"
            });

            List<HarvestJob> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MediaPackageV2ListHarvestJobs()
        {
            #region example-4

            var client = new AmazonMediaPackageV2Client();
            var response = client.ListHarvestJobs(new ListHarvestJobsRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannelName",
                OriginEndpointName = "exampleOriginEndpointName",
                Status = "QUEUED"
            });

            List<HarvestJob> items = response.Items;
            string nextToken = response.NextToken;

            #endregion
        }

        public void MediaPackageV2ListHarvestJobs()
        {
            #region example-5

            var client = new AmazonMediaPackageV2Client();
            var response = client.ListHarvestJobs(new ListHarvestJobsRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannelName",
                OriginEndpointName = "exampleOriginEndpointName"
            });


            #endregion
        }

        public void MediaPackageV2ListOriginEndpoints()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.ListOriginEndpoints(new ListOriginEndpointsRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel"
            });

            List<OriginEndpointListConfiguration> items = response.Items;

            #endregion
        }

        public void MediaPackageV2ListTagsForResource()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceArn = "arn:aws:mediapackagev2:us-west-2:123456789012:channelGroup/exampleChannelGroup/channel/exampleChannel"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MediaPackageV2PutChannelPolicy()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.PutChannelPolicy(new PutChannelPolicyRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel",
                Policy = "{...}"
            });


            #endregion
        }

        public void MediaPackageV2PutOriginEndpointPolicy()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.PutOriginEndpointPolicy(new PutOriginEndpointPolicyRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel",
                OriginEndpointName = "exampleOriginEndpoint",
                Policy = "{...}"
            });


            #endregion
        }

        public void MediaPackageV2ResetChannelState()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.ResetChannelState(new ResetChannelStateRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel"
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            DateTime resetAt = response.ResetAt;

            #endregion
        }

        public void MediaPackageV2ResetOriginEndpointState()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.ResetOriginEndpointState(new ResetOriginEndpointStateRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel",
                OriginEndpointName = "exampleOriginEndpoint"
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            string originEndpointName = response.OriginEndpointName;
            DateTime resetAt = response.ResetAt;

            #endregion
        }

        public void MediaPackageV2TagResource()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceArn = "arn:aws:mediapackagev2:us-west-2:123456789012:channelGroup/exampleChannelGroup/channel/exampleChannel",
                Tags = new Dictionary<string, string> {
                    { "key3", "value3" },
                    { "key4", "value4" }
                }
            });


            #endregion
        }

        public void MediaPackageV2UntagResource()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceArn = "arn:aws:mediapackagev2:us-west-2:123456789012:channelGroup/exampleChannelGroup/channel/exampleChannel",
                TagKeys = new List<string> {
                    "key3",
                    "key4"
                }
            });


            #endregion
        }

        public void MediaPackageV2UpdateChannel()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.UpdateChannel(new UpdateChannelRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel",
                Description = "Updated description for exampleChannel"
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string eTag = response.ETag;
            List<IngestEndpoint> ingestEndpoints = response.IngestEndpoints;
            string inputType = response.InputType;
            DateTime modifiedAt = response.ModifiedAt;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MediaPackageV2UpdateChannelGroup()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.UpdateChannelGroup(new UpdateChannelGroupRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                Description = "Updated description for exampleChannelGroup"
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string eTag = response.ETag;
            string egressDomain = response.EgressDomain;
            DateTime modifiedAt = response.ModifiedAt;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MediaPackageV2UpdateOriginEndpoint()
        {
            #region example-1

            var client = new AmazonMediaPackageV2Client();
            var response = client.UpdateOriginEndpoint(new UpdateOriginEndpointRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel",
                ContainerType = "TS",
                Description = "Updated description for exampleOriginEndpointTS",
                ForceEndpointErrorConfiguration = new ForceEndpointErrorConfiguration { EndpointErrorConditions = new List<string> {
                    "STALE_MANIFEST",
                    "INCOMPLETE_MANIFEST",
                    "MISSING_DRM_KEY",
                    "SLATE_INPUT"
                } },
                HlsManifests = new List<CreateHlsManifestConfiguration> {
                    new CreateHlsManifestConfiguration {
                        ChildManifestName = "exampleChildManifest1",
                        ManifestName = "exampleManifest1",
                        ManifestWindowSeconds = 30,
                        ProgramDateTimeIntervalSeconds = 60,
                        ScteHls = new ScteHls { AdMarkerHls = "DATERANGE" }
                    },
                    new CreateHlsManifestConfiguration {
                        ChildManifestName = "exampleManifest2",
                        ManifestName = "exampleManifest2",
                        ManifestWindowSeconds = 30,
                        ProgramDateTimeIntervalSeconds = 60,
                        ScteHls = new ScteHls { AdMarkerHls = "DATERANGE" }
                    }
                },
                LowLatencyHlsManifests = new List<CreateLowLatencyHlsManifestConfiguration> {
                    new CreateLowLatencyHlsManifestConfiguration {
                        ChildManifestName = "exampleLLChildManifest1",
                        ManifestName = "exampleLLManifest1",
                        ManifestWindowSeconds = 30,
                        ProgramDateTimeIntervalSeconds = 60,
                        ScteHls = new ScteHls { AdMarkerHls = "DATERANGE" }
                    },
                    new CreateLowLatencyHlsManifestConfiguration {
                        ChildManifestName = "exampleLLManifest2",
                        ManifestName = "exampleLLManifest2",
                        ManifestWindowSeconds = 30,
                        ProgramDateTimeIntervalSeconds = 60,
                        ScteHls = new ScteHls { AdMarkerHls = "DATERANGE" }
                    }
                },
                OriginEndpointName = "exampleOriginEndpointTS",
                Segment = new Segment {
                    Encryption = new Encryption {
                        ConstantInitializationVector = "A382A901F3C1F7718512266CFFBB0B7E",
                        EncryptionMethod = new EncryptionMethod { TsEncryptionMethod = "AES_128" },
                        KeyRotationIntervalSeconds = 300,
                        SpekeKeyProvider = new SpekeKeyProvider {
                            DrmSystems = new List<string> {
                                "CLEAR_KEY_AES_128"
                            },
                            EncryptionContractConfiguration = new EncryptionContractConfiguration {
                                PresetSpeke20Audio = "SHARED",
                                PresetSpeke20Video = "SHARED"
                            },
                            ResourceId = "ResourceId",
                            RoleArn = "arn:aws:iam::123456789012:role/empRole",
                            Url = "https://foo.com"
                        }
                    },
                    IncludeIframeOnlyStreams = false,
                    Scte = new Scte { ScteFilter = new List<string> {
                        "SPLICE_INSERT"
                    } },
                    SegmentDurationSeconds = 7,
                    SegmentName = "segmentName2",
                    TsIncludeDvbSubtitles = false,
                    TsUseAudioRenditionGroup = true
                },
                StartoverWindowSeconds = 600
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            string containerType = response.ContainerType;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string eTag = response.ETag;
            ForceEndpointErrorConfiguration forceEndpointErrorConfiguration = response.ForceEndpointErrorConfiguration;
            List<GetHlsManifestConfiguration> hlsManifests = response.HlsManifests;
            List<GetLowLatencyHlsManifestConfiguration> lowLatencyHlsManifests = response.LowLatencyHlsManifests;
            DateTime modifiedAt = response.ModifiedAt;
            string originEndpointName = response.OriginEndpointName;
            Segment segment = response.Segment;
            int startoverWindowSeconds = response.StartoverWindowSeconds;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void MediaPackageV2UpdateOriginEndpoint()
        {
            #region example-2

            var client = new AmazonMediaPackageV2Client();
            var response = client.UpdateOriginEndpoint(new UpdateOriginEndpointRequest 
            {
                ChannelGroupName = "exampleChannelGroup",
                ChannelName = "exampleChannel",
                ContainerType = "ISM",
                Description = "Updated description for exampleOriginEndpointISM",
                ForceEndpointErrorConfiguration = new ForceEndpointErrorConfiguration { EndpointErrorConditions = new List<string> {
                    "STALE_MANIFEST",
                    "INCOMPLETE_MANIFEST",
                    "MISSING_DRM_KEY",
                    "SLATE_INPUT"
                } },
                MssManifests = new List<CreateMssManifestConfiguration> {
                    new CreateMssManifestConfiguration {
                        ManifestLayout = "FULL",
                        ManifestName = "exampleMssManifest1",
                        ManifestWindowSeconds = 60
                    },
                    new CreateMssManifestConfiguration {
                        ManifestLayout = "COMPACT",
                        ManifestName = "exampleMssManifest2",
                        ManifestWindowSeconds = 30
                    }
                },
                OriginEndpointName = "exampleOriginEndpointISM",
                Segment = new Segment {
                    Encryption = new Encryption {
                        EncryptionMethod = new EncryptionMethod { IsmEncryptionMethod = "CENC" },
                        SpekeKeyProvider = new SpekeKeyProvider {
                            DrmSystems = new List<string> {
                                "PLAYREADY"
                            },
                            EncryptionContractConfiguration = new EncryptionContractConfiguration {
                                PresetSpeke20Audio = "SHARED",
                                PresetSpeke20Video = "SHARED"
                            },
                            ResourceId = "ResourceId",
                            RoleArn = "arn:aws:iam::123456789012:role/empRole",
                            Url = "https://speke-key-provider.example.com"
                        }
                    },
                    SegmentDurationSeconds = 2,
                    SegmentName = "segmentName2"
                },
                StartoverWindowSeconds = 600
            });

            string arn = response.Arn;
            string channelGroupName = response.ChannelGroupName;
            string channelName = response.ChannelName;
            string containerType = response.ContainerType;
            DateTime createdAt = response.CreatedAt;
            string description = response.Description;
            string eTag = response.ETag;
            ForceEndpointErrorConfiguration forceEndpointErrorConfiguration = response.ForceEndpointErrorConfiguration;
            DateTime modifiedAt = response.ModifiedAt;
            List<GetMssManifestConfiguration> mssManifests = response.MssManifests;
            string originEndpointName = response.OriginEndpointName;
            Segment segment = response.Segment;
            int startoverWindowSeconds = response.StartoverWindowSeconds;
            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}