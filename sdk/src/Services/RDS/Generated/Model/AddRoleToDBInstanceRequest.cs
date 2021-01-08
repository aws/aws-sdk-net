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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the AddRoleToDBInstance operation.
    /// Associates an AWS Identity and Access Management (IAM) role with a DB instance.
    /// 
    ///  <note> 
    /// <para>
    /// To add a role to a DB instance, the status of the DB instance must be <code>available</code>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AddRoleToDBInstanceRequest : AmazonRDSRequest
    {
        private string _dbInstanceIdentifier;
        private string _featureName;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The name of the DB instance to associate the IAM role with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureName. 
        /// <para>
        /// The name of the feature for the DB instance that the IAM role is to be associated
        /// with. For the list of supported feature names, see <a>DBEngineVersion</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FeatureName
        {
            get { return this._featureName; }
            set { this._featureName = value; }
        }

        // Check to see if FeatureName property is set
        internal bool IsSetFeatureName()
        {
            return this._featureName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to associate with the DB instance,
        /// for example <code>arn:aws:iam::123456789012:role/AccessRole</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}