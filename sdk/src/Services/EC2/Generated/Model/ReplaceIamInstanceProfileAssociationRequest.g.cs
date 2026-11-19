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
    /// Container for the parameters to the ReplaceIamInstanceProfileAssociation operation.
    /// Replaces an IAM instance profile for the specified running instance. You can use this
    /// action to change the IAM instance profile that's associated with an instance without
    /// having to disassociate the existing IAM instance profile first. <para> Use <a>DescribeIamInstanceProfileAssociations</a>
    /// to get the association ID. </para>
    /// </summary>
    public partial class ReplaceIamInstanceProfileAssociationRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the existing IAM instance profile association.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The IAM instance profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IamInstanceProfileSpecification IamInstanceProfile { get; set; }

        /// <summary>
        /// Checks to see if the IamInstanceProfile property is set.
        /// </summary>
        internal bool IsSetIamInstanceProfile() => this.IamInstanceProfile != null;
    }
}
