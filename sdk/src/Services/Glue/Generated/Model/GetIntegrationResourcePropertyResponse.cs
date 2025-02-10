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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the GetIntegrationResourceProperty operation.
    /// </summary>
    public partial class GetIntegrationResourcePropertyResponse : AmazonWebServiceResponse
    {
        private string _resourceArn;
        private SourceProcessingProperties _sourceProcessingProperties;
        private TargetProcessingProperties _targetProcessingProperties;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The connection ARN of the source, or the database ARN of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceProcessingProperties. 
        /// <para>
        /// The resource properties associated with the integration source.
        /// </para>
        /// </summary>
        public SourceProcessingProperties SourceProcessingProperties
        {
            get { return this._sourceProcessingProperties; }
            set { this._sourceProcessingProperties = value; }
        }

        // Check to see if SourceProcessingProperties property is set
        internal bool IsSetSourceProcessingProperties()
        {
            return this._sourceProcessingProperties != null;
        }

        /// <summary>
        /// Gets and sets the property TargetProcessingProperties. 
        /// <para>
        /// The resource properties associated with the integration target.
        /// </para>
        /// </summary>
        public TargetProcessingProperties TargetProcessingProperties
        {
            get { return this._targetProcessingProperties; }
            set { this._targetProcessingProperties = value; }
        }

        // Check to see if TargetProcessingProperties property is set
        internal bool IsSetTargetProcessingProperties()
        {
            return this._targetProcessingProperties != null;
        }

    }
}