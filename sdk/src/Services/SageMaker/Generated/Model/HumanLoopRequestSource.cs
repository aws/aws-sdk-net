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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for configuring the source of human task requests.
    /// </summary>
    public partial class HumanLoopRequestSource
    {
        private AwsManagedHumanLoopRequestSource _awsManagedHumanLoopRequestSource;

        /// <summary>
        /// Gets and sets the property AwsManagedHumanLoopRequestSource. 
        /// <para>
        /// Specifies whether Amazon Rekognition or Amazon Textract are used as the integration
        /// source. The default field settings and JSON parsing rules are different based on the
        /// integration source. Valid values:
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AwsManagedHumanLoopRequestSource AwsManagedHumanLoopRequestSource
        {
            get { return this._awsManagedHumanLoopRequestSource; }
            set { this._awsManagedHumanLoopRequestSource = value; }
        }

        // Check to see if AwsManagedHumanLoopRequestSource property is set
        internal bool IsSetAwsManagedHumanLoopRequestSource()
        {
            return this._awsManagedHumanLoopRequestSource != null;
        }

    }
}