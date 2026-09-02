using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SageMakerFeatureStoreRuntime;
using Amazon.SageMakerFeatureStoreRuntime.Model;

namespace AWSSDKDocSamples.Amazon.SageMakerFeatureStoreRuntime.Generated
{
    class SageMakerFeatureStoreRuntimeSamples : ISample
    {
        public void SageMakerFeatureStoreRuntimeBatchWriteRecord()
        {
            #region batch-write-record-example-1

            var client = new AmazonSageMakerFeatureStoreRuntimeClient();
            var response = client.BatchWriteRecord(new BatchWriteRecordRequest 
            {
                Entries = new List<BatchWriteRecordEntry> {
                    new BatchWriteRecordEntry {
                        FeatureGroupName = "my-feature-group",
                        Record = new List<FeatureValue> {
                            new FeatureValue {
                                FeatureName = "customer_id",
                                ValueAsString = "cust-001"
                            },
                            new FeatureValue {
                                FeatureName = "age",
                                ValueAsString = "25"
                            }
                        }
                    }
                }
            });

            List<BatchWriteRecordError> errors = response.Errors;
            List<BatchWriteRecordEntry> unprocessedEntries = response.UnprocessedEntries;

            #endregion
        }

        public void SageMakerFeatureStoreRuntimeListRecords()
        {
            #region list-records-example-1

            var client = new AmazonSageMakerFeatureStoreRuntimeClient();
            var response = client.ListRecords(new ListRecordsRequest 
            {
                FeatureGroupName = "my-feature-group",
                MaxResults = 10
            });

            string nextToken = response.NextToken;
            List<string> recordIdentifiers = response.RecordIdentifiers;

            #endregion
        }

        public void SageMakerFeatureStoreRuntimeUpdateRecord()
        {
            #region update-record-example-1

            var client = new AmazonSageMakerFeatureStoreRuntimeClient();
            var response = client.UpdateRecord(new UpdateRecordRequest 
            {
                FeatureGroupName = "my-feature-group",
                Features = new List<FeatureValue> {
                    new FeatureValue {
                        FeatureName = "age",
                        ValueAsString = "26"
                    },
                    new FeatureValue {
                        FeatureName = "membership_tier",
                        ValueAsString = "gold"
                    },
                    new FeatureValue {
                        FeatureName = "event_time",
                        ValueAsString = "2026-07-26T12:00:00Z"
                    }
                },
                RecordIdentifierValueAsString = "cust-001"
            });


            #endregion
        }

        public void SageMakerFeatureStoreRuntimeUpdateRecord()
        {
            #region update-record-example-2

            var client = new AmazonSageMakerFeatureStoreRuntimeClient();
            var response = client.UpdateRecord(new UpdateRecordRequest 
            {
                FeatureGroupName = "my-feature-group",
                Features = new List<FeatureValue> {
                    new FeatureValue {
                        FeatureName = "age",
                        ValueAsString = "26"
                    },
                    new FeatureValue {
                        FeatureName = "event_time",
                        ValueAsString = "2026-07-26T12:00:00Z"
                    }
                },
                RecordIdentifierValueAsString = "cust-001",
                TtlDuration = new TtlDuration {
                    Unit = "Weeks",
                    Value = 4
                }
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