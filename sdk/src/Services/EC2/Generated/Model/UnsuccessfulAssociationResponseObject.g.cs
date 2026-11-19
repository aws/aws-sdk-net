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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an unsuccessful application status check association.
    /// </summary>
    public partial class UnsuccessfulAssociationResponseObject
    {
        /// <summary>
        /// Gets and sets the property ApplicationStatusCheckId. 
        /// <para>
        /// The ID of the application status check.
        /// </para>
        /// </summary>
        public string ApplicationStatusCheckId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationStatusCheckId property is set.
        /// </summary>
        internal bool IsSetApplicationStatusCheckId() => this.ApplicationStatusCheckId != null;

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The type of association. Valid values: <c>EC2TAG</c> and <c>INSTANCE_ID</c>.
        /// </para>
        /// </summary>
        public string AssociationType { get; set; }

        /// <summary>
        /// Checks to see if the AssociationType property is set.
        /// </summary>
        internal bool IsSetAssociationType() => this.AssociationType != null;

        /// <summary>
        /// Gets and sets the property AssociationValue. 
        /// <para>
        /// The association value. For <c>EC2TAG</c>, the value is formatted as <c>key=value</c>.
        /// For <c>INSTANCE_ID</c>, the value is the instance ID.
        /// </para>
        /// </summary>
        public string AssociationValue { get; set; }

        /// <summary>
        /// Checks to see if the AssociationValue property is set.
        /// </summary>
        internal bool IsSetAssociationValue() => this.AssociationValue != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason the association failed.
        /// </para>
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;
    }
}
