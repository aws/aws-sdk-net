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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the CreateNamespace operation.
    /// </summary>
    public partial class CreateNamespaceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the Quick Sight namespace you created. 
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CapacityRegion. 
        /// <para>
        /// The Amazon Web Services Region; that you want to use for the free SPICE capacity for
        /// the new namespace. This is set to the region that you run CreateNamespace in. 
        /// </para>
        /// </summary>
        public string CapacityRegion { get; set; }

        /// <summary>
        /// Checks to see if the CapacityRegion property is set.
        /// </summary>
        internal bool IsSetCapacityRegion() => this.CapacityRegion != null;

        /// <summary>
        /// Gets and sets the property CreationStatus. 
        /// <para>
        /// The status of the creation of the namespace. This is an asynchronous process. A status
        /// of <c>CREATED</c> means that your namespace is ready to use. If an error occurs, it
        /// indicates if the process is <c>retryable</c> or <c>non-retryable</c>. In the case
        /// of a non-retryable error, refer to the error message for follow-up tasks.
        /// </para>
        /// </summary>
        public NamespaceStatus CreationStatus { get; set; }

        /// <summary>
        /// Checks to see if the CreationStatus property is set.
        /// </summary>
        internal bool IsSetCreationStatus() => this.CreationStatus != null;

        /// <summary>
        /// Gets and sets the property IdentityStore. 
        /// <para>
        /// Specifies the type of your user identity directory. Currently, this supports users
        /// with an identity type of <c>QUICKSIGHT</c>.
        /// </para>
        /// </summary>
        public IdentityStore IdentityStore { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStore property is set.
        /// </summary>
        internal bool IsSetIdentityStore() => this.IdentityStore != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new namespace that you created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;
    }
}
