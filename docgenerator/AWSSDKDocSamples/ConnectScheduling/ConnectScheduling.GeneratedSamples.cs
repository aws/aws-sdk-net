using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.ConnectScheduling;
using Amazon.ConnectScheduling.Model;

namespace AWSSDKDocSamples.Amazon.ConnectScheduling.Generated
{
    class ConnectSchedulingSamples : ISample
    {
        public void ConnectSchedulingApproveTimeOff()
        {
            #region ApproveTimeOff-1

            var client = new AmazonConnectSchedulingClient();
            var response = client.ApproveTimeOff(new ApproveTimeOffRequest
            {
                Description = "Approved with coverage from the evening shift",
                InstanceId = "12345678-1234-1234-1234-123456789012",
                RuleFailureAction = "OVERRIDE",
                TimeOffId = "abcdef12-3456-7890-abcd-ef1234567890",
                UserId = "87654321-4321-4321-4321-210987654321"
            });


            #endregion
        }

        public void ConnectSchedulingCancelTimeOff()
        {
            #region CancelTimeOff-1

            var client = new AmazonConnectSchedulingClient();
            var response = client.CancelTimeOff(new CancelTimeOffRequest
            {
                Description = "Plans changed",
                InstanceId = "12345678-1234-1234-1234-123456789012",
                TimeOffId = "abcdef12-3456-7890-abcd-ef1234567890",
                UserId = "87654321-4321-4321-4321-210987654321"
            });


            #endregion
        }

        public void ConnectSchedulingCreateTimeOff()
        {
            #region CreateTimeOff-1

            var client = new AmazonConnectSchedulingClient();
            var response = client.CreateTimeOff(new CreateTimeOffRequest
            {
                ApprovalType = "AWAIT_APPROVAL",
                Description = "Family event",
                EndAt = new DateTime(2026, 11, 23, 17, 0, 0, DateTimeKind.Utc),
                InstanceId = "12345678-1234-1234-1234-123456789012",
                ShiftActivityId = "11112222-3333-4444-5555-666677778888",
                StartAt = new DateTime(2026, 11, 23, 9, 0, 0, DateTimeKind.Utc),
                UserId = "87654321-4321-4321-4321-210987654321"
            });

            string timeOffId = response.TimeOffId;

            #endregion
        }

        public void ConnectSchedulingGetTimeOff()
        {
            #region GetTimeOff-1

            var client = new AmazonConnectSchedulingClient();
            var response = client.GetTimeOff(new GetTimeOffRequest
            {
                InstanceId = "12345678-1234-1234-1234-123456789012",
                TimeOffId = "abcdef12-3456-7890-abcd-ef1234567890",
                UserId = "87654321-4321-4321-4321-210987654321"
            });

            DateTime? createdAt = response.CreatedAt;
            ActorInfo createdBy = response.CreatedBy;
            string description = response.Description;
            DateTime? endAt = response.EndAt;
            string shiftActivityId = response.ShiftActivityId;
            DateTime? startAt = response.StartAt;
            TimeOffStatus status = response.Status;
            string timeOffId = response.TimeOffId;
            DateTime? updatedAt = response.UpdatedAt;
            ActorInfo updatedBy = response.UpdatedBy;
            string userId = response.UserId;
            List<TimeOffValidationResult> validationResults = response.ValidationResults;

            #endregion
        }

        public void ConnectSchedulingPutTimeOffBalance()
        {
            #region PutTimeOffBalance-1

            var client = new AmazonConnectSchedulingClient();
            var response = client.PutTimeOffBalance(new PutTimeOffBalanceRequest
            {
                Balance = new Duration {
                    Unit = "HOURS",
                    Value = 80
                },
                InstanceId = "12345678-1234-1234-1234-123456789012",
                ShiftActivityId = "11112222-3333-4444-5555-666677778888",
                UserId = "87654321-4321-4321-4321-210987654321"
            });


            #endregion
        }

        public void ConnectSchedulingRejectTimeOff()
        {
            #region RejectTimeOff-1

            var client = new AmazonConnectSchedulingClient();
            var response = client.RejectTimeOff(new RejectTimeOffRequest
            {
                Description = "Not enough coverage for this shift",
                InstanceId = "12345678-1234-1234-1234-123456789012",
                TimeOffId = "abcdef12-3456-7890-abcd-ef1234567890",
                UserId = "87654321-4321-4321-4321-210987654321"
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
