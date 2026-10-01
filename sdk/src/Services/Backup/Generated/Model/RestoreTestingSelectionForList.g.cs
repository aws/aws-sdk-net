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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This contains metadata about a restore testing selection.
    /// </summary>
    public partial class RestoreTestingSelectionForList
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a restore testing selection was created, in Unix format and
        /// Coordinated Universal Time (UTC). The value of <c>CreationTime</c> is accurate to
        /// milliseconds. For example, the value 1516925490.087 represents Friday, January 26,2018
        /// 12:11:30.087 AM.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Backup uses to create the target
        /// resource; for example: <c>arn:aws:iam::123456789012:role/S3Access</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property ProtectedResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource included in a restore testing selection;
        /// for example, an Amazon EBS volume or an Amazon RDS database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProtectedResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ProtectedResourceType property is set.
        /// </summary>
        internal bool IsSetProtectedResourceType() => this.ProtectedResourceType != null;

        /// <summary>
        /// Gets and sets the property RestoreTestingPlanName. 
        /// <para>
        /// Unique string that is the name of the restore testing plan.
        /// </para>
        ///  
        /// <para>
        /// The name cannot be changed after creation. The name must consist of only alphanumeric
        /// characters and underscores. Maximum length is 50.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestoreTestingPlanName { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTestingPlanName property is set.
        /// </summary>
        internal bool IsSetRestoreTestingPlanName() => this.RestoreTestingPlanName != null;

        /// <summary>
        /// Gets and sets the property RestoreTestingSelectionName. 
        /// <para>
        /// Unique name of a restore testing selection.
        /// </para>
        ///  
        /// <para>
        /// The name consists of only alphanumeric characters and underscores. Maximum length
        /// is 50.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestoreTestingSelectionName { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTestingSelectionName property is set.
        /// </summary>
        internal bool IsSetRestoreTestingSelectionName() => this.RestoreTestingSelectionName != null;

        /// <summary>
        /// Gets and sets the property ValidationWindowHours. 
        /// <para>
        /// This value represents the time, in hours, data is retained after a restore test so
        /// that optional validation can be completed.
        /// </para>
        ///  
        /// <para>
        /// Accepted value is an integer between 0 and 168 (the hourly equivalent of seven days).
        /// </para>
        /// </summary>
        public int? ValidationWindowHours { get; set; }

        /// <summary>
        /// Checks to see if the ValidationWindowHours property is set.
        /// </summary>
        internal bool IsSetValidationWindowHours() => this.ValidationWindowHours.HasValue;
    }
}
