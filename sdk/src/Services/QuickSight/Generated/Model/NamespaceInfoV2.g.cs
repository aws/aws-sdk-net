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
    /// The error type.
    /// </summary>
    public partial class NamespaceInfoV2
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The namespace ARN.
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
        /// The namespace Amazon Web Services Region.
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
        /// The creation status of a namespace that is not yet completely created.
        /// </para>
        /// </summary>
        public NamespaceStatus CreationStatus { get; set; }

        /// <summary>
        /// Checks to see if the CreationStatus property is set.
        /// </summary>
        internal bool IsSetCreationStatus() => this.CreationStatus != null;

        /// <summary>
        /// Gets and sets the property IamIdentityCenterApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM Identity Center application.
        /// </para>
        /// </summary>
        public string IamIdentityCenterApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the IamIdentityCenterApplicationArn property is set.
        /// </summary>
        internal bool IsSetIamIdentityCenterApplicationArn() => this.IamIdentityCenterApplicationArn != null;

        /// <summary>
        /// Gets and sets the property IamIdentityCenterInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM Identity Center instance.
        /// </para>
        /// </summary>
        public string IamIdentityCenterInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IamIdentityCenterInstanceArn property is set.
        /// </summary>
        internal bool IsSetIamIdentityCenterInstanceArn() => this.IamIdentityCenterInstanceArn != null;

        /// <summary>
        /// Gets and sets the property IdentityStore. 
        /// <para>
        /// The identity store used for the namespace.
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
        /// The name of the error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NamespaceError. 
        /// <para>
        /// An error that occurred when the namespace was created.
        /// </para>
        /// </summary>
        public NamespaceError NamespaceError { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceError property is set.
        /// </summary>
        internal bool IsSetNamespaceError() => this.NamespaceError != null;
    }
}
