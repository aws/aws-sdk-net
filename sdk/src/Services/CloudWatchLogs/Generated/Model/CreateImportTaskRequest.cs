/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateImportTask operation.
    /// Starts an import from a data source to CloudWatch Log and creates a managed log group
    /// as the destination for the imported data. Currently, <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/query-event-data-store.html">CloudTrail
    /// Event Data Store</a> is the only supported data source. 
    /// 
    ///  
    /// <para>
    /// The import task must satisfy the following constraints:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The specified source must be in an ACTIVE state.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The API caller must have permissions to access the data in the provided source and
    /// to perform iam:PassRole on the provided import role which has the same permissions,
    /// as described below.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The provided IAM role must trust the "cloudtrail.amazonaws.com" principal and have
    /// the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// cloudtrail:GetEventDataStoreData
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// logs:CreateLogGroup
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// logs:CreateLogStream
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// logs:PutResourcePolicy
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (If source has an associated AWS KMS Key) kms:Decrypt
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (If source has an associated AWS KMS Key) kms:GenerateDataKey
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Example IAM policy for provided import role:
    /// </para>
    ///  
    /// <para>
    ///  <c>[ { "Effect": "Allow", "Action": "iam:PassRole", "Resource": "arn:aws:iam::123456789012:role/apiCallerCredentials",
    /// "Condition": { "StringLike": { "iam:AssociatedResourceARN": "arn:aws:logs:us-east-1:123456789012:log-group:aws/cloudtrail/f1d45bff-d0e3-4868-b5d9-2eb678aa32fb:*"
    /// } } }, { "Effect": "Allow", "Action": [ "cloudtrail:GetEventDataStoreData" ], "Resource":
    /// [ "arn:aws:cloudtrail:us-east-1:123456789012:eventdatastore/f1d45bff-d0e3-4868-b5d9-2eb678aa32fb"
    /// ] }, { "Effect": "Allow", "Action": [ "logs:CreateImportTask", "logs:CreateLogGroup",
    /// "logs:CreateLogStream", "logs:PutResourcePolicy" ], "Resource": [ "arn:aws:logs:us-east-1:123456789012:log-group:/aws/cloudtrail/*"
    /// ] }, { "Effect": "Allow", "Action": [ "kms:Decrypt", "kms:GenerateDataKey" ], "Resource":
    /// [ "arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012" ]
    /// } ]</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the import source has a customer managed key, the "cloudtrail.amazonaws.com" principal
    /// needs permissions to perform kms:Decrypt and kms:GenerateDataKey.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// There can be no more than 3 active imports per account at a given time.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The startEventTime must be less than or equal to endEventTime.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The data being imported must be within the specified source's retention period.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateImportTaskRequest : AmazonCloudWatchLogsRequest
    {
        private ImportFilter _importFilter;
        private string _importRoleArn;
        private string _importSourceArn;

        /// <summary>
        /// Gets and sets the property ImportFilter. 
        /// <para>
        /// Optional filters to constrain the import by CloudTrail event time. Times are specified
        /// in Unix timestamp milliseconds. The range of data being imported must be within the
        /// specified source's retention period.
        /// </para>
        /// </summary>
        public ImportFilter ImportFilter
        {
            get { return this._importFilter; }
            set { this._importFilter = value; }
        }

        // Check to see if ImportFilter property is set
        internal bool IsSetImportFilter()
        {
            return this._importFilter != null;
        }

        /// <summary>
        /// Gets and sets the property ImportRoleArn. 
        /// <para>
        /// The ARN of the IAM role that grants CloudWatch Logs permission to import from the
        /// CloudTrail Lake Event Data Store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ImportRoleArn
        {
            get { return this._importRoleArn; }
            set { this._importRoleArn = value; }
        }

        // Check to see if ImportRoleArn property is set
        internal bool IsSetImportRoleArn()
        {
            return this._importRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImportSourceArn. 
        /// <para>
        /// The ARN of the source to import from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImportSourceArn
        {
            get { return this._importSourceArn; }
            set { this._importSourceArn = value; }
        }

        // Check to see if ImportSourceArn property is set
        internal bool IsSetImportSourceArn()
        {
            return this._importSourceArn != null;
        }

    }
}