using System;
using System.Collections.Generic;
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
            #region creates-a-retraining-scheduler-with-manual-promote-mode-1694018486212

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
            string status = response.Status;

            #endregion
        }

        public void LookoutEquipmentCreateRetrainingScheduler()
        {
            #region creates-a-retraining-scheduler-with-a-specific-start-date-1694018790519

            var client = new AmazonLookoutEquipmentClient();
            var response = client.CreateRetrainingScheduler(new CreateRetrainingSchedulerRequest 
            {
                ClientToken = "sample-client-token",
                LookbackWindow = "P360D",
                ModelName = "sample-model",
                RetrainingFrequency = "P1M",
                RetrainingStartDate = new DateTime(2024, 1, 1, 12, 0, 0, DateTimeKind.Utc)
            });

            string modelArn = response.ModelArn;
            string modelName = response.ModelName;
            string status = response.Status;

            #endregion
        }

        public void LookoutEquipmentDeleteRetrainingScheduler()
        {
            #region deletes-a-retraining-scheduler-1694019240097

            var client = new AmazonLookoutEquipmentClient();
            var response = client.DeleteRetrainingScheduler(new DeleteRetrainingSchedulerRequest 
            {
                ModelName = "sample-model"
            });


            #endregion
        }

        public void LookoutEquipmentDescribeRetrainingScheduler()
        {
            #region describes-a-retraining-scheduler-1694019344252

            var client = new AmazonLookoutEquipmentClient();
            var response = client.DescribeRetrainingScheduler(new DescribeRetrainingSchedulerRequest 
            {
                ModelName = "sample-model"
            });

            DateTime createdAt = response.CreatedAt;
            string lookbackWindow = response.LookbackWindow;
            string modelArn = response.ModelArn;
            string modelName = response.ModelName;
            string promoteMode = response.PromoteMode;
            string retrainingFrequency = response.RetrainingFrequency;
            DateTime retrainingStartDate = response.RetrainingStartDate;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;

            #endregion
        }

        public void LookoutEquipmentListRetrainingSchedulers()
        {
            #region listing-retraining-schedulers-1694016740503

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
            #region starts-a-retraining-scheduler-1694019629413

            var client = new AmazonLookoutEquipmentClient();
            var response = client.StartRetrainingScheduler(new StartRetrainingSchedulerRequest 
            {
                ModelName = "sample-model"
            });

            string modelArn = response.ModelArn;
            string modelName = response.ModelName;
            string status = response.Status;

            #endregion
        }

        public void LookoutEquipmentStopRetrainingScheduler()
        {
            #region stops-a-retraining-scheduler-1694019734149

            var client = new AmazonLookoutEquipmentClient();
            var response = client.StopRetrainingScheduler(new StopRetrainingSchedulerRequest 
            {
                ModelName = "sample-model"
            });

            string modelArn = response.ModelArn;
            string modelName = response.ModelName;
            string status = response.Status;

            #endregion
        }

        public void LookoutEquipmentUpdateModel()
        {
            #region updates-a-model-1694020683458

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
            #region updates-a-retraining-scheduler-1694019840918

            var client = new AmazonLookoutEquipmentClient();
            var response = client.UpdateRetrainingScheduler(new UpdateRetrainingSchedulerRequest 
            {
                ModelName = "sample-model",
                RetrainingFrequency = "P1Y",
                RetrainingStartDate = new DateTime(2024, 1, 1, 12, 0, 0, DateTimeKind.Utc)
            });


            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}