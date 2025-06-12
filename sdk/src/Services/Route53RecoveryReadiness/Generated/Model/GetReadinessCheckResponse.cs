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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
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
namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// This is the response object from the GetReadinessCheck operation.
    /// </summary>
    public partial class GetReadinessCheckResponse : AmazonWebServiceResponse
    {
        private string _readinessCheckArn;
        private string _readinessCheckName;
        private string _resourceSet;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ReadinessCheckArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with a readiness check.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ReadinessCheckArn
        {
            get { return this._readinessCheckArn; }
            set { this._readinessCheckArn = value; }
        }

        // Check to see if ReadinessCheckArn property is set
        internal bool IsSetReadinessCheckArn()
        {
            return this._readinessCheckArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReadinessCheckName. 
        /// <para>
        /// Name of a readiness check.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string ReadinessCheckName
        {
            get { return this._readinessCheckName; }
            set { this._readinessCheckName = value; }
        }

        // Check to see if ReadinessCheckName property is set
        internal bool IsSetReadinessCheckName()
        {
            return this._readinessCheckName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSet. 
        /// <para>
        /// Name of the resource set to be checked.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string ResourceSet
        {
            get { return this._resourceSet; }
            set { this._resourceSet = value; }
        }

        // Check to see if ResourceSet property is set
        internal bool IsSetResourceSet()
        {
            return this._resourceSet != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}