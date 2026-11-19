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

namespace Amazon.LambdaCore.Model
{
    /// <summary>
    /// This is the response object from the RestoreRuntime operation.
    /// </summary>
    public partial class RestoreRuntimeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. The fully qualified ARN of the resource that was restored
        /// (runtime, version, or alias).
        /// </summary>
        [AWSProperty(Required = true, Min = 48, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property LastModified. The date and time when the restored resource
        /// was last modified.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified != null;

        /// <summary>
        /// Gets and sets the property RuntimeAlias. Echoed back only when the request supplied
        /// a RuntimeAlias qualifier.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RuntimeAlias { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeAlias property is set.
        /// </summary>
        internal bool IsSetRuntimeAlias() => this.RuntimeAlias != null;

        /// <summary>
        /// Gets and sets the property RuntimeName. The name or ARN of the runtime.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2048)]
        public string RuntimeName { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeName property is set.
        /// </summary>
        internal bool IsSetRuntimeName() => this.RuntimeName != null;

        /// <summary>
        /// Gets and sets the property RuntimeVersion. Echoed back only when the request supplied
        /// a RuntimeVersion qualifier.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeVersion property is set.
        /// </summary>
        internal bool IsSetRuntimeVersion() => this.RuntimeVersion != null;

        /// <summary>
        /// Gets and sets the property State. The state of the restored resource, ACTIVE on success.
        /// </summary>
        [AWSProperty(Required = true)]
        public RuntimeState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
