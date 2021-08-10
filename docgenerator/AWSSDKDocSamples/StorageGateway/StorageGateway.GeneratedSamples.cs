using System;
using System.Collections.Generic;
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
            #region to-activate-the-gateway-1471281611207

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
            #region to-add-a-cache-1471043606854

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
            #region to-add-tags-to-resource-1471283689460

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
            #region to-add-upload-buffer-on-local-disk-1471293902847

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
            #region to-add-storage-on-local-disk-1471294305401

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
            #region to-cancel-virtual-tape-archiving-1471294865203

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
            #region to-cancel-virtual-tape-retrieval-1471295704491

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
            #region to-create-a-cached-iscsi-volume-1471296661787

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
            #region to-create-a-snapshot-of-a-gateway-volume-1471301469561

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
            #region to-create-a-snapshot-of-a-gateway-volume-1471301469561

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
            #region to-create-a-stored-iscsi-volume-1471367662813

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
            long volumeSizeInBytes = response.VolumeSizeInBytes;

            #endregion
        }

        public void StorageGatewayCreateTapes()
        {
            #region to-create-a-virtual-tape-1471372061659

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
            #region to-create-a-virtual-tape-using-a-barcode-1471371842452

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
            #region to-delete-bandwidth-rate-limits-of-gateway-1471373225520

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
            #region to-delete-chap-credentials-1471375025612

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
            #region to-delete-a-gatgeway-1471381697333

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
            #region to-delete-a-snapshot-of-a-volume-1471382234377

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
            #region to-delete-a-virtual-tape-1471382444157

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
            #region to-delete-a-virtual-tape-from-the-shelf-vts-1471383964329

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
            #region to-delete-a-gateway-volume-1471384418416

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
            #region to-describe-the-bandwidth-rate-limits-of-a-gateway-1471384826404

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeBandwidthRateLimit(new DescribeBandwidthRateLimitRequest 
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            long averageDownloadRateLimitInBitsPerSec = response.AverageDownloadRateLimitInBitsPerSec;
            long averageUploadRateLimitInBitsPerSec = response.AverageUploadRateLimitInBitsPerSec;
            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayDescribeCache()
        {
            #region to-describe-cache-information-1471385756036

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeCache(new DescribeCacheRequest 
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            long cacheAllocatedInBytes = response.CacheAllocatedInBytes;
            double cacheDirtyPercentage = response.CacheDirtyPercentage;
            double cacheHitPercentage = response.CacheHitPercentage;
            double cacheMissPercentage = response.CacheMissPercentage;
            double cacheUsedPercentage = response.CacheUsedPercentage;
            List<string> diskIds = response.DiskIds;
            string gatewayARN = response.GatewayARN;

            #endregion
        }

        public void StorageGatewayDescribeCachediSCSIVolumes()
        {
            #region to-describe-gateway-cached-iscsi-volumes-1471458094649

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
            #region to-describe-chap-credetnitals-for-an-iscsi-1471467462967

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
            #region to-describe-metadata-about-the-gateway-1471467849079

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
            #region to-describe-gateways-maintenance-start-time-1471470727387

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeMaintenanceStartTime(new DescribeMaintenanceStartTimeRequest 
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            int dayOfWeek = response.DayOfWeek;
            string gatewayARN = response.GatewayARN;
            int hourOfDay = response.HourOfDay;
            int minuteOfHour = response.MinuteOfHour;
            string timezone = response.Timezone;

            #endregion
        }

        public void StorageGatewayDescribeSnapshotSchedule()
        {
            #region to-describe-snapshot-schedule-for-gateway-volume-1471471139538

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeSnapshotSchedule(new DescribeSnapshotScheduleRequest 
            {
                VolumeARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B/volume/vol-1122AABB"
            });

            string description = response.Description;
            int recurrenceInHours = response.RecurrenceInHours;
            int startAt = response.StartAt;
            string timezone = response.Timezone;
            string volumeARN = response.VolumeARN;

            #endregion
        }

        public void StorageGatewayDescribeStorediSCSIVolumes()
        {
            #region to-describe-the-volumes-of-a-gateway-1471472640660

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

        public void StorageGatewayDescribeTapeArchives()
        {
            #region to-describe-virtual-tapes-in-the-vts-1471473188198

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeTapeArchives(new DescribeTapeArchivesRequest 
            {
                Limit = 123,
                Marker = "1",
                TapeARNs = new List<string> {
                    "arn:aws:storagegateway:us-east-1:999999999999:tape/AM08A1AD",
                    "arn:aws:storagegateway:us-east-1:999999999999:tape/AMZN01A2A4"
                }
            });

            string marker = response.Marker;
            List<TapeArchive> tapeArchives = response.TapeArchives;

            #endregion
        }

        public void StorageGatewayDescribeTapeRecoveryPoints()
        {
            #region to-describe-virtual-tape-recovery-points-1471542042026

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeTapeRecoveryPoints(new DescribeTapeRecoveryPointsRequest 
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B",
                Limit = 1,
                Marker = "1"
            });

            string gatewayARN = response.GatewayARN;
            string marker = response.Marker;
            List<TapeRecoveryPointInfo> tapeRecoveryPointInfos = response.TapeRecoveryPointInfos;

            #endregion
        }

        public void StorageGatewayDescribeTapes()
        {
            #region to-describe-virtual-tapes-associated-with-gateway-1471629287727

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
            #region to-describe-upload-buffer-of-gateway-1471631099003

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeUploadBuffer(new DescribeUploadBufferRequest 
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            List<string> diskIds = response.DiskIds;
            string gatewayARN = response.GatewayARN;
            long uploadBufferAllocatedInBytes = response.UploadBufferAllocatedInBytes;
            long uploadBufferUsedInBytes = response.UploadBufferUsedInBytes;

            #endregion
        }

        public void StorageGatewayDescribeUploadBuffer()
        {
            #region to-describe-upload-buffer-of-a-gateway--1471904566370

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeUploadBuffer(new DescribeUploadBufferRequest 
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            List<string> diskIds = response.DiskIds;
            string gatewayARN = response.GatewayARN;
            long uploadBufferAllocatedInBytes = response.UploadBufferAllocatedInBytes;
            long uploadBufferUsedInBytes = response.UploadBufferUsedInBytes;

            #endregion
        }

        public void StorageGatewayDescribeVTLDevices()
        {
            #region to-describe-virtual-tape-library-vtl-devices-of-a-single-gateway-1471906071410

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
            #region to-describe-the-working-storage-of-a-gateway-depreciated-1472070842332

            var client = new AmazonStorageGatewayClient();
            var response = client.DescribeWorkingStorage(new DescribeWorkingStorageRequest 
            {
                GatewayARN = "arn:aws:storagegateway:us-east-1:111122223333:gateway/sgw-12A3456B"
            });

            List<string> diskIds = response.DiskIds;
            string gatewayARN = response.GatewayARN;
            long workingStorageAllocatedInBytes = response.WorkingStorageAllocatedInBytes;
            long workingStorageUsedInBytes = response.WorkingStorageUsedInBytes;

            #endregion
        }

        public void StorageGatewayDisableGateway()
        {
            #region to-disable-a-gateway-when-it-is-no-longer-functioning-1472076046936

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
            #region to-lists-region-specific-gateways-per-aws-account-1472077860657

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
            #region to-list-the-gateways-local-disks-1472079564618

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
            #region to-list-tags-that-have-been-added-to-a-resource-1472080268972

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
            #region to-list-recovery-points-for-a-gateway-1472143015088

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
            #region to-list-the-iscsi-stored-volumes-of-a-gateway-1472145723653

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
            #region to-remove-tags-from-a-resource-1472147210553

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
            #region to-reset-cache-disks-in-error-status-1472148909807

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
            #region to-retrieve-an-archived-tape-from-the-vts-1472149812358

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
            #region to-retrieve-the-recovery-point-of-a-virtual-tape-1472150014805

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
            #region to-set-a-password-for-your-vm-1472150202632

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
            #region to-shut-down-a-gateway-service-1472150508835

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
            #region to-start-a-gateway-service-1472150722315

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
            #region to-update-the-bandwidth-rate-limits-of-a-gateway-1472151016202

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
            #region to-update-chap-credentials-for-an-iscsi-target-1472151325795

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
            #region to-update-a-gateways-metadata-1472151688693

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
            #region to-update-a-gateways-vm-software-1472152020929

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
            #region to-update-a-gateways-maintenance-start-time-1472152552031

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
            #region to-update-a-volume-snapshot-schedule-1472152757068

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
            #region to-update-a-vtl-device-type-1472153012967

            var client = new AmazonStorageGatewayClient();
            var response = client.UpdateVTLDeviceType(new UpdateVTLDeviceTypeRequest 
            {
                DeviceType = "Medium Changer",
                VTLDeviceARN = "arn:aws:storagegateway:us-east-1:999999999999:gateway/sgw-12A3456B/device/AMZN_SGW-1FAD4876_MEDIACHANGER_00001"
            });

            string vtlDeviceARN = response.VTLDeviceARN;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}