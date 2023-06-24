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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteObservabilityConfiguration operation.
    /// Delete an App Runner observability configuration resource. You can delete a specific
    /// revision or the latest active revision. You can't delete a configuration that's used
    /// by one or more App Runner services.
    /// </summary>
    public partial class DeleteObservabilityConfigurationRequest : AmazonAppRunnerRequest
    {
        private string _observabilityConfigurationArn;

        /// <summary>
        /// Gets and sets the property ObservabilityConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the App Runner observability configuration that
        /// you want to delete.
        /// </para>
        ///  
        /// <para>
        /// The ARN can be a full observability configuration ARN, or a partial ARN ending with
        /// either <code>.../<i>name</i> </code> or <code>.../<i>name</i>/<i>revision</i> </code>.
        /// If a revision isn't specified, the latest active revision is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ObservabilityConfigurationArn
        {
            get { return this._observabilityConfigurationArn; }
            set { this._observabilityConfigurationArn = value; }
        }

        // Check to see if ObservabilityConfigurationArn property is set
        internal bool IsSetObservabilityConfigurationArn()
        {
            return this._observabilityConfigurationArn != null;
        }

    }
}