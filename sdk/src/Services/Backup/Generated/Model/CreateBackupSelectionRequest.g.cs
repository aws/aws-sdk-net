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
    /// Container for the parameters to the CreateBackupSelection operation. Creates a JSON
    /// document that specifies a set of resources to assign to a backup plan. For examples,
    /// see <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/assigning-resources.html#assigning-resources-json">Assigning
    /// resources programmatically</a>.
    /// </summary>
    public partial class CreateBackupSelectionRequest : AmazonBackupRequest
    {
        /// <summary>
        /// Gets and sets the property BackupPlanId. 
        /// <para>
        /// The ID of the backup plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// Checks to see if the BackupPlanId property is set.
        /// </summary>
        internal bool IsSetBackupPlanId() => this.BackupPlanId != null;

        /// <summary>
        /// Gets and sets the property BackupSelection. 
        /// <para>
        /// The body of a request to assign a set of resources to a backup plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BackupSelection BackupSelection { get; set; }

        /// <summary>
        /// Checks to see if the BackupSelection property is set.
        /// </summary>
        internal bool IsSetBackupSelection() => this.BackupSelection != null;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and allows failed requests to be retried
        /// without the risk of running the operation twice. This parameter is optional.
        /// </para>
        ///  
        /// <para>
        /// If used, this parameter must contain 1 to 50 alphanumeric or '-_.' characters.
        /// </para>
        /// </summary>
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;
    }
}
