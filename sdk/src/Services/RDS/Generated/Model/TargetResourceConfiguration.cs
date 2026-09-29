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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The configuration for a single resource in the green environment of a blue/green deployment.
    /// 
    ///  
    /// <para>
    /// Use <c>SourceArn</c> to identify a resource in the blue environment. Amazon RDS creates
    /// the corresponding resource in the green environment using this configuration.
    /// </para>
    ///  
    /// <para>
    /// This data type is a request parameter of the <c>CreateBlueGreenDeployment</c> operation.
    /// </para>
    /// </summary>
    public partial class TargetResourceConfiguration
    {
        private string _sourceArn;
        private string _targetKmsKeyId;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DB cluster or DB instance in the blue environment
        /// to which this configuration applies.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=39, Max=255)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetKmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for encryption of the corresponding resource
        /// in the green environment.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias ARN, or alias
        /// name for the KMS key.
        /// </para>
        ///  
        /// <para>
        /// Specify this setting in either of the following cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You want the green resource to use a different KMS key than the blue resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The blue resource is unencrypted and you want to encrypt the green resource.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For Aurora, encryption applies at the DB cluster level. Specify a DB cluster ARN in
        /// <c>SourceArn</c>. All DB instances in that cluster use the same KMS key.
        /// </para>
        ///  
        /// <para>
        /// For RDS, encryption applies at the DB instance level. Specify a DB instance ARN in
        /// <c>SourceArn</c>. To encrypt read replicas, include a separate entry for each one.
        /// Each entry can specify a different KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string TargetKmsKeyId
        {
            get { return this._targetKmsKeyId; }
            set { this._targetKmsKeyId = value; }
        }

        // Check to see if TargetKmsKeyId property is set
        internal bool IsSetTargetKmsKeyId()
        {
            return this._targetKmsKeyId != null;
        }

    }
}