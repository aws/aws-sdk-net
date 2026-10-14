using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.LookoutEquipment;
using Amazon.LookoutEquipment.Model;

namespace AWSSDKDocSamples.Amazon.LookoutEquipment.Generated
{
    class LookoutEquipmentSamples : ISample
    {
        public void LookoutEquipmentCreateRetrainingScheduler()
        {
            #region CreateRetrainingScheduler-1

            var client = new AmazonLookoutEquipmentClient();
            var response = client.CreateRetrainingScheduler(new CreateRetrainingSchedulerRequest
            {
                ClientToken = "sample-client-token",
                LookbackWindow = "P360D",
                ModelName = "sample-model",
                RetrainingFrequency = "P1M",
                RetrainingStartDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            });

            string modelArn = response.ModelArn;
            string modelName = response.ModelName;
            RetrainingSchedulerStatus status = response.Status;

            #endregion
        }

        public void LookoutEquipmentCreateRetrainingScheduler()
        {
            #region CreateRetrainingScheduler-2

            var client = new AmazonLookoutEquipmentClient();
            var response = client.CreateRetrainingScheduler(new CreateRetrainingSchedulerRequest
            {
                ClientToken = "sample-client-token",
                LookbackWindow = "P360D",
                ModelName = "sample-model",
                PromoteMode = "MANUAL",
                RetrainingFrequency = "P1M"
            });

            string modelArn = response.ModelArn;
            string modelName = response.ModelName;
            RetrainingSchedulerStatus status = response.Status;

            #endregion
        }

        public void LookoutEquipmentDeleteRetrainingScheduler()
        {
            #region DeleteRetrainingScheduler-1

            var client = new AmazonLookoutEquipmentClient();
            var response = client.DeleteRetrainingScheduler(new DeleteRetrainingSchedulerRequest
            {
                ModelName = "sample-model"
            });


            #endregion
        }

        public void LookoutEquipmentDescribeRetrainingScheduler()
        {
            #region DescribeRetrainingScheduler-1

            var client = new AmazonLookoutEquipmentClient();
            var response = client.DescribeRetrainingScheduler(new DescribeRetrainingSchedulerRequest
            {
                ModelName = "sample-model"
            });

            DateTime? createdAt = response.CreatedAt;
            string lookbackWindow = response.LookbackWindow;
            string modelArn = response.ModelArn;
            string modelName = response.ModelName;
            ModelPromoteMode promoteMode = response.PromoteMode;
            string retrainingFrequency = response.RetrainingFrequency;
            DateTime? retrainingStartDate = response.RetrainingStartDate;
            RetrainingSchedulerStatus status = response.Status;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void LookoutEquipmentListRetrainingSchedulers()
        {
            #region ListRetrainingSchedulers-1

            var client = new AmazonLookoutEquipmentClient();
            var response = client.ListRetrainingSchedulers(new ListRetrainingSchedulersRequest
            {
                MaxResults = 50
            });

            List<RetrainingSchedulerSummary> retrainingSchedulerSummaries = response.RetrainingSchedulerSummaries;

            #endregion
        }

        public void LookoutEquipmentStartRetrainingScheduler()
        {
            #region StartRetrainingScheduler-1

            var client = new AmazonLookoutEquipmentClient();
            var response = client.StartRetrainingScheduler(new StartRetrainingSchedulerRequest
            {
                ModelName = "sample-model"
            });

            string modelArn = response.ModelArn;
            string modelName = response.ModelName;
            RetrainingSchedulerStatus status = response.Status;

            #endregion
        }

        public void LookoutEquipmentStopRetrainingScheduler()
        {
            #region StopRetrainingScheduler-1

            var client = new AmazonLookoutEquipmentClient();
            var response = client.StopRetrainingScheduler(new StopRetrainingSchedulerRequest
            {
                ModelName = "sample-model"
            });

            string modelArn = response.ModelArn;
            string modelName = response.ModelName;
            RetrainingSchedulerStatus status = response.Status;

            #endregion
        }

        public void LookoutEquipmentUpdateModel()
        {
            #region UpdateModel-1

            var client = new AmazonLookoutEquipmentClient();
            var response = client.UpdateModel(new UpdateModelRequest
            {
                LabelsInputConfiguration = new LabelsInputConfiguration { LabelGroupName = "sample-label-group" },
                ModelName = "sample-model"
            });


            #endregion
        }

        public void LookoutEquipmentUpdateRetrainingScheduler()
        {
            #region UpdateRetrainingScheduler-1

            var client = new AmazonLookoutEquipmentClient();
            var response = client.UpdateRetrainingScheduler(new UpdateRetrainingSchedulerRequest
            {
                ModelName = "sample-model",
                RetrainingFrequency = "P1Y",
                RetrainingStartDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            });


            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
