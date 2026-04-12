using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Deadline;
using Amazon.Deadline.Model;

namespace AWSSDKDocSamples.Amazon.Deadline.Generated
{
    class DeadlineSamples : ISample
    {
        public void DeadlineBatchGetJob()
        {
            #region example-1

            var client = new AmazonDeadlineClient();
            var response = client.BatchGetJob(new BatchGetJobRequest 
            {
                Identifiers = new List<BatchGetJobIdentifier> {
                    new BatchGetJobIdentifier {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        JobId = "job-1234567890abcdef1234567890abcdef",
                        QueueId = "queue-1234567890abcdef1234567890abcdef"
                    },
                    new BatchGetJobIdentifier {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        JobId = "job-234567890abcdef1234567890abcdef1",
                        QueueId = "queue-1234567890abcdef1234567890abcdef"
                    }
                }
            });


            #endregion
        }

        public void DeadlineBatchGetSession()
        {
            #region example-1

            var client = new AmazonDeadlineClient();
            var response = client.BatchGetSession(new BatchGetSessionRequest 
            {
                Identifiers = new List<BatchGetSessionIdentifier> {
                    new BatchGetSessionIdentifier {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        JobId = "job-1234567890abcdef1234567890abcdef",
                        QueueId = "queue-1234567890abcdef1234567890abcdef",
                        SessionId = "session-1234567890abcdef1234567890abcdef"
                    },
                    new BatchGetSessionIdentifier {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        JobId = "job-1234567890abcdef1234567890abcdef",
                        QueueId = "queue-1234567890abcdef1234567890abcdef",
                        SessionId = "session-234567890abcdef1234567890abcdef1"
                    }
                }
            });


            #endregion
        }

        public void DeadlineBatchGetSessionAction()
        {
            #region example-1

            var client = new AmazonDeadlineClient();
            var response = client.BatchGetSessionAction(new BatchGetSessionActionRequest 
            {
                Identifiers = new List<BatchGetSessionActionIdentifier> {
                    new BatchGetSessionActionIdentifier {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        JobId = "job-1234567890abcdef1234567890abcdef",
                        QueueId = "queue-1234567890abcdef1234567890abcdef",
                        SessionActionId = "sessionaction-1234567890abcdef1234567890abcdef-0"
                    },
                    new BatchGetSessionActionIdentifier {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        JobId = "job-1234567890abcdef1234567890abcdef",
                        QueueId = "queue-1234567890abcdef1234567890abcdef",
                        SessionActionId = "sessionaction-1234567890abcdef1234567890abcdef-1"
                    }
                }
            });


            #endregion
        }

        public void DeadlineBatchGetStep()
        {
            #region example-1

            var client = new AmazonDeadlineClient();
            var response = client.BatchGetStep(new BatchGetStepRequest 
            {
                Identifiers = new List<BatchGetStepIdentifier> {
                    new BatchGetStepIdentifier {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        JobId = "job-1234567890abcdef1234567890abcdef",
                        QueueId = "queue-1234567890abcdef1234567890abcdef",
                        StepId = "step-1234567890abcdef1234567890abcdef"
                    },
                    new BatchGetStepIdentifier {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        JobId = "job-1234567890abcdef1234567890abcdef",
                        QueueId = "queue-1234567890abcdef1234567890abcdef",
                        StepId = "step-234567890abcdef1234567890abcdef1"
                    }
                }
            });


            #endregion
        }

        public void DeadlineBatchGetTask()
        {
            #region example-1

            var client = new AmazonDeadlineClient();
            var response = client.BatchGetTask(new BatchGetTaskRequest 
            {
                Identifiers = new List<BatchGetTaskIdentifier> {
                    new BatchGetTaskIdentifier {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        JobId = "job-1234567890abcdef1234567890abcdef",
                        QueueId = "queue-1234567890abcdef1234567890abcdef",
                        StepId = "step-1234567890abcdef1234567890abcdef",
                        TaskId = "task-1234567890abcdef1234567890abcdef-0"
                    },
                    new BatchGetTaskIdentifier {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        JobId = "job-1234567890abcdef1234567890abcdef",
                        QueueId = "queue-1234567890abcdef1234567890abcdef",
                        StepId = "step-1234567890abcdef1234567890abcdef",
                        TaskId = "task-1234567890abcdef1234567890abcdef-1"
                    }
                }
            });


            #endregion
        }

        public void DeadlineBatchGetWorker()
        {
            #region example-1

            var client = new AmazonDeadlineClient();
            var response = client.BatchGetWorker(new BatchGetWorkerRequest 
            {
                Identifiers = new List<BatchGetWorkerIdentifier> {
                    new BatchGetWorkerIdentifier {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        FleetId = "fleet-1234567890abcdef1234567890abcdef",
                        WorkerId = "worker-1234567890abcdef1234567890abcdef"
                    },
                    new BatchGetWorkerIdentifier {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        FleetId = "fleet-1234567890abcdef1234567890abcdef",
                        WorkerId = "worker-234567890abcdef1234567890abcdef1"
                    }
                }
            });


            #endregion
        }

        public void DeadlineBatchUpdateJob()
        {
            #region example-1

            var client = new AmazonDeadlineClient();
            var response = client.BatchUpdateJob(new BatchUpdateJobRequest 
            {
                Jobs = new List<BatchUpdateJobItem> {
                    new BatchUpdateJobItem {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        JobId = "job-1234567890abcdef1234567890abcdef",
                        QueueId = "queue-1234567890abcdef1234567890abcdef",
                        TargetTaskRunStatus = "FAILED"
                    },
                    new BatchUpdateJobItem {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        JobId = "job-234567890abcdef1234567890abcdef1",
                        QueueId = "queue-1234567890abcdef1234567890abcdef",
                        TargetTaskRunStatus = "FAILED"
                    }
                }
            });


            #endregion
        }

        public void DeadlineBatchUpdateTask()
        {
            #region example-1

            var client = new AmazonDeadlineClient();
            var response = client.BatchUpdateTask(new BatchUpdateTaskRequest 
            {
                Tasks = new List<BatchUpdateTaskItem> {
                    new BatchUpdateTaskItem {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        JobId = "job-1234567890abcdef1234567890abcdef",
                        QueueId = "queue-1234567890abcdef1234567890abcdef",
                        StepId = "step-1234567890abcdef1234567890abcdef",
                        TargetRunStatus = "FAILED",
                        TaskId = "task-1234567890abcdef1234567890abcdef-0"
                    },
                    new BatchUpdateTaskItem {
                        FarmId = "farm-1234567890abcdef1234567890abcdef",
                        JobId = "job-1234567890abcdef1234567890abcdef",
                        QueueId = "queue-1234567890abcdef1234567890abcdef",
                        StepId = "step-1234567890abcdef1234567890abcdef",
                        TargetRunStatus = "FAILED",
                        TaskId = "task-1234567890abcdef1234567890abcdef-1"
                    }
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