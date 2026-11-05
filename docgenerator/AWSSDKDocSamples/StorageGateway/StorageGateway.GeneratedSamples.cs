using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.StorageGateway;
using Amazon.StorageGateway.Model;

namespace AWSSDKDocSamples.Amazon.StorageGateway.Generated
{
    class StorageGatewaySamples : ISample
    {
        public void StorageGatewayActivateGateway()
        {
            #region ActivateGateway-1

            var client = new AmazonStorageGatewayClient();
            var response = client.ActivateGateway(new ActivateGatewayRequest
            {
                ActivationKey = "29AV1-3OFV9-VVIUB-NKT0I-LRO6V",
                GatewayName = "My_Gateway",
                GatewayRegion = "us-east-1",
                GatewayTimezone = "GMT-12:00",
                GatewayType = "STORED",
                MediumChangerType = "AWS-Gateway-VTL",
                TapeDriveType = "IBM-ULT3580-TD5"
            });

            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayAddCache()
        {
            #region AddCache-1

            var client = new AmazonStorageGatewayClient();
            var response = client.AddCache(new AddCacheRequest
            {
                DiskIds = new List<string> {
                    "pci-0000:03:00.0-scsi-0:0:0:0",
                    "pci-0000:03:00.0-scsi-0:0:1:0"
                },
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayAddTagsToResource()
        {
            #region AddTagsToResource-1

            var client = new AmazonStorageGatewayClient();
            var response = client.AddTagsToResource(new AddTagsToResourceRequest
            {
                ResourceARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-11A2222B",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Dev Gatgeway Region",
                        Value = "East Coast"
                    }
                }
            });

            string resourceARN = response.ResourceARN;

            #endregion
        }

        public void StorageGatewayAddUploadBuffer()
        {
            #region AddUploadBuffer-1

            var client = new AmazonStorageGatewayClient();
            var response = client.AddUploadBuffer(new AddUploadBufferRequest
            {
                DiskIds = new List<string> {
                    "pci-0000:03:00.0-scsi-0:0:0:0",
                    "pci-0000:03:00.0-scsi-0:0:1:0"
                },
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayAddWorkingStorage()
        {
            #region AddWorkingStorage-1

            var client = new AmazonStorageGatewayClient();
            var response = client.AddWorkingStorage(new AddWorkingStorageRequest
            {
                DiskIds = new List<string> {
                    "pci-0000:03:00.0-scsi-0:0:0:0",
                    "pci-0000:03:00.0-scsi-0:0:1:0"
                },
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayCancelArchival()
        {
            #region CancelArchival-1

            var client = new AmazonStorageGatewayClient();
            var response = client.CancelArchival(new CancelArchivalRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B",
                TapeARN = "arn:aws:storagegateway:us-east-1:999999999999:tape/AMZN01A2A4"
            });

            string tapeARN = response.TapeARN;

            #endregion
        }

        public void StorageGatewayCancelRetrieval()
        {
            #region CancelRetrieval-1

            var client = new AmazonStorageGatewayClient();
            var response = client.CancelRetrieval(new CancelRetrievalRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B",
                TapeARN = "arn:aws:storagegateway:us-east-1:999999999999:tape/AMZN01A2A4"
            });

            string tapeARN = response.TapeARN;

            #endregion
        }

        public void StorageGatewayCreateCachediSCSIVolume()
        {
            #region CreateCachediSCSIVolume-1

            var client = new AmazonStorageGatewayClient();
            var response = client.CreateCachediSCSIVolume(new CreateCachediSCSIVolumeRequest
            {
                ClientToken = "cachedvol112233",
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B",
                NetworkInterfaceId = "10.1.1.1",
                SnapshotId = "snap-f47b7b94",
                TargetName = "my-volume",
                VolumeSizeInBytes = 536870912000
            });

            string targetARN = response.TargetARN;
            string volumeARN = response.VolumeARN;

            #endregion
        }

        public void StorageGatewayCreateSnapshot()
        {
            #region CreateSnapshot-1

            var client = new AmazonStorageGatewayClient();
            var response = client.CreateSnapshot(new CreateSnapshotRequest
            {
                SnapshotDescription = "My root volume snapshot as of 10/03/2017",
                VolumeARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B/volume/vol-1122AABB"
            });

            string snapshotId = response.SnapshotId;
            string volumeARN = response.VolumeARN;

            #endregion
        }

        public void StorageGatewayCreateSnapshotFromVolumeRecoveryPoint()
        {
            #region CreateSnapshotFromVolumeRecoveryPoint-1

            var client = new AmazonStorageGatewayClient();
            var response = client.CreateSnapshotFromVolumeRecoveryPoint(new CreateSnapshotFromVolumeRecoveryPointRequest
            {
                SnapshotDescription = "My root volume snapshot as of 2017-06-30T10:10:10.000Z",
                VolumeARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B/volume/vol-1122AABB"
            });

            string snapshotId = response.SnapshotId;
            string volumeARN = response.VolumeARN;
            string volumeRecoveryPointTime = response.VolumeRecoveryPointTime;

            #endregion
        }

        public void StorageGatewayCreateStorediSCSIVolume()
        {
            #region CreateStorediSCSIVolume-1

            var client = new AmazonStorageGatewayClient();
            var response = client.CreateStorediSCSIVolume(new CreateStorediSCSIVolumeRequest
            {
                DiskId = "pci-0000:03:00.0-scsi-0:0:0:0",
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B",
                NetworkInterfaceId = "10.1.1.1",
                PreserveExistingData = true,
                SnapshotId = "snap-f47b7b94",
                TargetName = "my-volume"
            });

            string targetARN = response.TargetARN;
            string volumeARN = response.VolumeARN;
            long? volumeSizeInBytes = response.VolumeSizeInBytes;

            #endregion
        }

        public void StorageGatewayCreateTapes()
        {
            #region CreateTapes-1

            var client = new AmazonStorageGatewayClient();
            var response = client.CreateTapes(new CreateTapesRequest
            {
                ClientToken = "77777",
                GatewayARN = "arn:aws:storagegateway:us-east-1:999999999999:gateway/sgw-12A3456B",
                NumTapesToCreate = 3,
                TapeBarcodePrefix = "TEST",
                TapeSizeInBytes = 107374182400
            });

            List<string> tapeARNs = response.TapeARNs;

            #endregion
        }

        public void StorageGatewayCreateTapeWithBarcode()
        {
            #region CreateTapeWithBarcode-1

            var client = new AmazonStorageGatewayClient();
            var response = client.CreateTapeWithBarcode(new CreateTapeWithBarcodeRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:999999999999:gateway/sgw-12A3456B",
                TapeBarcode = "TEST12345",
                TapeSizeInBytes = 107374182400
            });

            string tapeARN = response.TapeARN;

            #endregion
        }

        public void StorageGatewayDeleteBandwidthRateLimit()
        {
            #region DeleteBandwidthRateLimit-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DeleteBandwidthRateLimit(new DeleteBandwidthRateLimitRequest
            {
                BandwidthType = "All",
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayDeleteChapCredentials()
        {
            #region DeleteChapCredentials-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DeleteChapCredentials(new DeleteChapCredentialsRequest
            {
                InitiatorName = "iqn.1991-05.com.microsoft:computername.domain.example.com",
                TargetARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B/target/iqn.1997-05.com.amazon:myvolume"
            });

            string initiatorName = response.InitiatorName;
            string targetARN = response.TargetARN;

            #endregion
        }

        public void StorageGatewayDeleteGateway()
        {
            #region DeleteGateway-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DeleteGateway(new DeleteGatewayRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayDeleteSnapshotSchedule()
        {
            #region DeleteSnapshotSchedule-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DeleteSnapshotSchedule(new DeleteSnapshotScheduleRequest
            {
                VolumeARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B/volume/vol-1122AABB"
            });

            string volumeARN = response.VolumeARN;

            #endregion
        }

        public void StorageGatewayDeleteTape()
        {
            #region DeleteTape-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DeleteTape(new DeleteTapeRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:204469490176:gateway/sgw-12A3456B",
                TapeARN = "arn:aws:storagegateway:us-east-1:204469490176:tape/TEST05A2A0"
            });

            string tapeARN = response.TapeARN;

            #endregion
        }

        public void StorageGatewayDeleteTapeArchive()
        {
            #region DeleteTapeArchive-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DeleteTapeArchive(new DeleteTapeArchiveRequest
            {
                TapeARN = "arn:aws:storagegateway:us-east-1:204469490176:tape/TEST05A2A0"
            });

            string tapeARN = response.TapeARN;

            #endregion
        }

        public void StorageGatewayDeleteVolume()
        {
            #region DeleteVolume-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DeleteVolume(new DeleteVolumeRequest
            {
                VolumeARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B/volume/vol-1122AABB"
            });

            string volumeARN = response.VolumeARN;

            #endregion
        }

        public void StorageGatewayDescribeBandwidthRateLimit()
        {
            #region DescribeBandwidthRateLimit-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeBandwidthRateLimit(new DescribeBandwidthRateLimitRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            long? averageDownloadRateLimitInBitsPerSec = response.AverageDownloadRateLimitInBitsPerSec;
            long? averageUploadRateLimitInBitsPerSec = response.AverageUploadRateLimitInBitsPerSec;
            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayDescribeCache()
        {
            #region DescribeCache-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeCache(new DescribeCacheRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            long? cacheAllocatedInBytes = response.CacheAllocatedInBytes;
            double? cacheDirtyPercentage = response.CacheDirtyPercentage;
            double? cacheHitPercentage = response.CacheHitPercentage;
            double? cacheMissPercentage = response.CacheMissPercentage;
            double? cacheUsedPercentage = response.CacheUsedPercentage;
            List<string> diskIds = response.DiskIds;
            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayDescribeCachediSCSIVolumes()
        {
            #region DescribeCachediSCSIVolumes-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeCachediSCSIVolumes(new DescribeCachediSCSIVolumesRequest
            {
                VolumeARNs = new List<string> {
                    "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B/volume/vol-1122AABB"
                }
            });

            List<CachediSCSIVolume> cachediSCSIVolumes = response.CachediSCSIVolumes;

            #endregion
        }

        public void StorageGatewayDescribeChapCredentials()
        {
            #region DescribeChapCredentials-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeChapCredentials(new DescribeChapCredentialsRequest
            {
                TargetARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B/target/iqn.1997-05.com.amazon:myvolume"
            });

            List<ChapInfo> chapCredentials = response.ChapCredentials;

            #endregion
        }

        public void StorageGatewayDescribeGatewayInformation()
        {
            #region DescribeGatewayInformation-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeGatewayInformation(new DescribeGatewayInformationRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            string gatewayARN = response.GatewayARN;
            string gatewayId = response.GatewayId;
            string gatewayName = response.GatewayName;
            List<NetworkInterface> gatewayNetworkInterfaces = response.GatewayNetworkInterfaces;
            string gatewayState = response.GatewayState;
            string gatewayTimezone = response.GatewayTimezone;
            string gatewayType = response.GatewayType;
            string lastSoftwareUpdate = response.LastSoftwareUpdate;
            string nextUpdateAvailabilityDate = response.NextUpdateAvailabilityDate;

            #endregion
        }

        public void StorageGatewayDescribeMaintenanceStartTime()
        {
            #region DescribeMaintenanceStartTime-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeMaintenanceStartTime(new DescribeMaintenanceStartTimeRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            int? dayOfWeek = response.DayOfWeek;
            string gatewayARN = response.GatewayARN;
            int? hourOfDay = response.HourOfDay;
            int? minuteOfHour = response.MinuteOfHour;
            string timezone = response.Timezone;

            #endregion
        }

        public void StorageGatewayDescribeSnapshotSchedule()
        {
            #region DescribeSnapshotSchedule-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeSnapshotSchedule(new DescribeSnapshotScheduleRequest
            {
                VolumeARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B/volume/vol-1122AABB"
            });

            string description = response.Description;
            int? recurrenceInHours = response.RecurrenceInHours;
            int? startAt = response.StartAt;
            string timezone = response.Timezone;
            string volumeARN = response.VolumeARN;

            #endregion
        }

        public void StorageGatewayDescribeStorediSCSIVolumes()
        {
            #region DescribeStorediSCSIVolumes-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeStorediSCSIVolumes(new DescribeStorediSCSIVolumesRequest
            {
                VolumeARNs = new List<string> {
                    "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B/volume/vol-1122AABB"
                }
            });

            List<StorediSCSIVolume> storediSCSIVolumes = response.StorediSCSIVolumes;

            #endregion
        }

        public void StorageGatewayDescribeTapes()
        {
            #region DescribeTapes-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeTapes(new DescribeTapesRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:999999999999:gateway/sgw-12A3456B",
                Limit = 2,
                Marker = "1",
                TapeARNs = new List<string> {
                    "arn:aws:storagegateway:us-east-1:999999999999:tape/TEST04A2A1",
                    "arn:aws:storagegateway:us-east-1:999999999999:tape/TEST05A2A0"
                }
            });

            string marker = response.Marker;
            List<Tape> tapes = response.Tapes;

            #endregion
        }

        public void StorageGatewayDescribeUploadBuffer()
        {
            #region DescribeUploadBuffer-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeUploadBuffer(new DescribeUploadBufferRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            List<string> diskIds = response.DiskIds;
            string gatewayARN = response.GatewayARN;
            long? uploadBufferAllocatedInBytes = response.UploadBufferAllocatedInBytes;
            long? uploadBufferUsedInBytes = response.UploadBufferUsedInBytes;

            #endregion
        }

        public void StorageGatewayDescribeUploadBuffer()
        {
            #region DescribeUploadBuffer-2

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeUploadBuffer(new DescribeUploadBufferRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            List<string> diskIds = response.DiskIds;
            string gatewayARN = response.GatewayARN;
            long? uploadBufferAllocatedInBytes = response.UploadBufferAllocatedInBytes;
            long? uploadBufferUsedInBytes = response.UploadBufferUsedInBytes;

            #endregion
        }

        public void StorageGatewayDescribeVTLDevices()
        {
            #region DescribeVTLDevices-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeVTLDevices(new DescribeVTLDevicesRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:999999999999:gateway/sgw-12A3456B",
                Limit = 123,
                Marker = "1",
                VTLDeviceARNs = new List<string> {
                }
            });

            string gatewayARN = response.GatewayARN;
            string marker = response.Marker;
            List<VTLDevice> vtlDevices = response.VTLDevices;

            #endregion
        }

        public void StorageGatewayDescribeWorkingStorage()
        {
            #region DescribeWorkingStorage-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeWorkingStorage(new DescribeWorkingStorageRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            List<string> diskIds = response.DiskIds;
            string gatewayARN = response.GatewayARN;
            long? workingStorageAllocatedInBytes = response.WorkingStorageAllocatedInBytes;
            long? workingStorageUsedInBytes = response.WorkingStorageUsedInBytes;

            #endregion
        }

        public void StorageGatewayDisableGateway()
        {
            #region DisableGateway-1

            var client = new AmazonStorageGatewayClient();
            var response = client.DisableGateway(new DisableGatewayRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayListGateways()
        {
            #region ListGateways-1

            var client = new AmazonStorageGatewayClient();
            var response = client.ListGateways(new ListGatewaysRequest
            {
                Limit = 2,
                Marker = "1"
            });

            List<GatewayInfo> gateways = response.Gateways;
            string marker = response.Marker;

            #endregion
        }

        public void StorageGatewayListLocalDisks()
        {
            #region ListLocalDisks-1

            var client = new AmazonStorageGatewayClient();
            var response = client.ListLocalDisks(new ListLocalDisksRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            List<Disk> disks = response.Disks;
            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayListTagsForResource()
        {
            #region ListTagsForResource-1

            var client = new AmazonStorageGatewayClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest
            {
                Limit = 1,
                Marker = "1",
                ResourceARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-11A2222B"
            });

            string marker = response.Marker;
            string resourceARN = response.ResourceARN;
            List<Tag> tags = response.Tags;

            #endregion
        }

        public void StorageGatewayListVolumeRecoveryPoints()
        {
            #region ListVolumeRecoveryPoints-1

            var client = new AmazonStorageGatewayClient();
            var response = client.ListVolumeRecoveryPoints(new ListVolumeRecoveryPointsRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            string gatewayARN = response.GatewayARN;
            List<VolumeRecoveryPointInfo> volumeRecoveryPointInfos = response.VolumeRecoveryPointInfos;

            #endregion
        }

        public void StorageGatewayListVolumes()
        {
            #region ListVolumes-1

            var client = new AmazonStorageGatewayClient();
            var response = client.ListVolumes(new ListVolumesRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B",
                Limit = 2,
                Marker = "1"
            });

            string gatewayARN = response.GatewayARN;
            string marker = response.Marker;
            List<VolumeInfo> volumeInfos = response.VolumeInfos;

            #endregion
        }

        public void StorageGatewayRemoveTagsFromResource()
        {
            #region RemoveTagsFromResource-1

            var client = new AmazonStorageGatewayClient();
            var response = client.RemoveTagsFromResource(new RemoveTagsFromResourceRequest
            {
                ResourceARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-11A2222B",
                TagKeys = new List<string> {
                    "Dev Gatgeway Region",
                    "East Coast"
                }
            });

            string resourceARN = response.ResourceARN;

            #endregion
        }

        public void StorageGatewayResetCache()
        {
            #region ResetCache-1

            var client = new AmazonStorageGatewayClient();
            var response = client.ResetCache(new ResetCacheRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-13B4567C"
            });

            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayRetrieveTapeArchive()
        {
            #region RetrieveTapeArchive-1

            var client = new AmazonStorageGatewayClient();
            var response = client.RetrieveTapeArchive(new RetrieveTapeArchiveRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:999999999999:gateway/sgw-12A3456B",
                TapeARN = "arn:aws:storagegateway:us-east-1:999999999999:tape/TEST0AA2AF"
            });

            string tapeARN = response.TapeARN;

            #endregion
        }

        public void StorageGatewayRetrieveTapeRecoveryPoint()
        {
            #region RetrieveTapeRecoveryPoint-1

            var client = new AmazonStorageGatewayClient();
            var response = client.RetrieveTapeRecoveryPoint(new RetrieveTapeRecoveryPointRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:999999999999:gateway/sgw-12A3456B",
                TapeARN = "arn:aws:storagegateway:us-east-1:999999999999:tape/TEST0AA2AF"
            });

            string tapeARN = response.TapeARN;

            #endregion
        }

        public void StorageGatewaySetLocalConsolePassword()
        {
            #region SetLocalConsolePassword-1

            var client = new AmazonStorageGatewayClient();
            var response = client.SetLocalConsolePassword(new SetLocalConsolePasswordRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:999999999999:gateway/sgw-12A3456B",
                LocalConsolePassword = "PassWordMustBeAtLeast6Chars."
            });

            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayShutdownGateway()
        {
            #region ShutdownGateway-1

            var client = new AmazonStorageGatewayClient();
            var response = client.ShutdownGateway(new ShutdownGatewayRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:999999999999:gateway/sgw-12A3456B"
            });

            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayStartGateway()
        {
            #region StartGateway-1

            var client = new AmazonStorageGatewayClient();
            var response = client.StartGateway(new StartGatewayRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:999999999999:gateway/sgw-12A3456B"
            });

            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayUpdateBandwidthRateLimit()
        {
            #region UpdateBandwidthRateLimit-1

            var client = new AmazonStorageGatewayClient();
            var response = client.UpdateBandwidthRateLimit(new UpdateBandwidthRateLimitRequest
            {
                AverageDownloadRateLimitInBitsPerSec = 102400,
                AverageUploadRateLimitInBitsPerSec = 51200,
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayUpdateChapCredentials()
        {
            #region UpdateChapCredentials-1

            var client = new AmazonStorageGatewayClient();
            var response = client.UpdateChapCredentials(new UpdateChapCredentialsRequest
            {
                InitiatorName = "iqn.1991-05.com.microsoft:computername.domain.example.com",
                SecretToAuthenticateInitiator = "111111111111",
                SecretToAuthenticateTarget = "222222222222",
                TargetARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B/target/iqn.1997-05.com.amazon:myvolume"
            });

            string initiatorName = response.InitiatorName;
            string targetARN = response.TargetARN;

            #endregion
        }

        public void StorageGatewayUpdateGatewayInformation()
        {
            #region UpdateGatewayInformation-1

            var client = new AmazonStorageGatewayClient();
            var response = client.UpdateGatewayInformation(new UpdateGatewayInformationRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B",
                GatewayName = "MyGateway2",
                GatewayTimezone = "GMT-12:00"
            });

            string gatewayARN = response.GatewayARN;
            string gatewayName = response.GatewayName;

            #endregion
        }

        public void StorageGatewayUpdateGatewaySoftwareNow()
        {
            #region UpdateGatewaySoftwareNow-1

            var client = new AmazonStorageGatewayClient();
            var response = client.UpdateGatewaySoftwareNow(new UpdateGatewaySoftwareNowRequest
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayUpdateMaintenanceStartTime()
        {
            #region UpdateMaintenanceStartTime-1

            var client = new AmazonStorageGatewayClient();
            var response = client.UpdateMaintenanceStartTime(new UpdateMaintenanceStartTimeRequest
            {
                DayOfWeek = 2,
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B",
                HourOfDay = 0,
                MinuteOfHour = 30
            });

            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayUpdateSnapshotSchedule()
        {
            #region UpdateSnapshotSchedule-1

            var client = new AmazonStorageGatewayClient();
            var response = client.UpdateSnapshotSchedule(new UpdateSnapshotScheduleRequest
            {
                Description = "Hourly snapshot",
                RecurrenceInHours = 1,
                StartAt = 0,
                VolumeARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B/volume/vol-1122AABB"
            });

            string volumeARN = response.VolumeARN;

            #endregion
        }

        public void StorageGatewayUpdateVTLDeviceType()
        {
            #region UpdateVTLDeviceType-1

            var client = new AmazonStorageGatewayClient();
            var response = client.UpdateVTLDeviceType(new UpdateVTLDeviceTypeRequest
            {
                DeviceType = "Medium Changer",
                VTLDeviceARN = "arn:aws:storagegateway:us-east-1:999999999999:gateway/sgw-12A3456B/device/AMZN_SGW-1FAD4876_MEDIACHANGER_00001"
            });

            string vtlDeviceARN = response.VTLDeviceARN;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
