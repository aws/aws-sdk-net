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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAuditSuppression operation. Creates a Device
    /// Defender audit suppression. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateAuditSuppression</a>
    /// action. </para>
    /// </summary>
    public partial class CreateAuditSuppressionRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property CheckName.
        /// </summary>
        [AWSProperty(Required = true)]
        public string CheckName { get; set; }

        /// <summary>
        /// Checks to see if the CheckName property is set.
        /// </summary>
        internal bool IsSetCheckName() => this.CheckName != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        ///  Each audit supression must have a unique client request token. If you try to create
        /// a new audit suppression with the same token as one that already exists, an exception
        /// occurs. If you omit this value, Amazon Web Services SDKs will automatically generate
        /// a unique client request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the audit suppression. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        ///  The epoch timestamp in seconds at which this suppression expires. 
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier.
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceIdentifier ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property SuppressIndefinitely. 
        /// <para>
        ///  Indicates whether a suppression should exist indefinitely or not. 
        /// </para>
        /// </summary>
        public bool? SuppressIndefinitely { get; set; }

        /// <summary>
        /// Checks to see if the SuppressIndefinitely property is set.
        /// </summary>
        internal bool IsSetSuppressIndefinitely() => this.SuppressIndefinitely.HasValue;
    }
}
