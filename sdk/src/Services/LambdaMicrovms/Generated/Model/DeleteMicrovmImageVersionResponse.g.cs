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

namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// This is the response object from the DeleteMicrovmImageVersion operation.
    /// </summary>
    public partial class DeleteMicrovmImageVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ImageIdentifier. 
        /// <para>
        /// The identifier of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ImageIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ImageIdentifier property is set.
        /// </summary>
        internal bool IsSetImageIdentifier() => this.ImageIdentifier != null;

        /// <summary>
        /// Gets and sets the property ImageVersion. 
        /// <para>
        /// The version that was deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ImageVersion { get; set; }

        /// <summary>
        /// Checks to see if the ImageVersion property is set.
        /// </summary>
        internal bool IsSetImageVersion() => this.ImageVersion != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the MicroVM image version after deletion.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MicrovmImageVersionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
