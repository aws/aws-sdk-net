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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFleetAdvisorCollector operation.
    /// <important> 
    /// <para>
    ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
    /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
    /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
    /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
    /// Web Services DMS Fleet Advisor end of support</a>. 
    /// </para>
    ///  </important> 
    /// <para>
    /// Creates a Fleet Advisor collector using the specified parameters.
    /// </para>
    /// </summary>
    public partial class CreateFleetAdvisorCollectorRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _collectorName;
        private string _description;
        private string _s3BucketName;
        private string _serviceAccessRoleArn;

        /// <summary>
        /// Gets and sets the property CollectorName. 
        /// <para>
        /// The name of your Fleet Advisor collector (for example, <c>sample-collector</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CollectorName
        {
            get { return this._collectorName; }
            set { this._collectorName = value; }
        }

        // Check to see if CollectorName property is set
        internal bool IsSetCollectorName()
        {
            return this._collectorName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A summary description of your Fleet Advisor collector.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The Amazon S3 bucket that the Fleet Advisor collector uses to store inventory metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The IAM role that grants permissions to access the specified Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceAccessRoleArn
        {
            get { return this._serviceAccessRoleArn; }
            set { this._serviceAccessRoleArn = value; }
        }

        // Check to see if ServiceAccessRoleArn property is set
        internal bool IsSetServiceAccessRoleArn()
        {
            return this._serviceAccessRoleArn != null;
        }

    }
}