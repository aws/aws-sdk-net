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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
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
namespace Amazon.RAM.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePermission operation.
    /// Creates a customer managed permission for a specified resource type that you can attach
    /// to resource shares. It is created in the Amazon Web Services Region in which you call
    /// the operation.
    /// </summary>
    public partial class CreatePermissionRequest : AmazonRAMRequest
    {
        private string _clientToken;
        private string _name;
        private string _policyTemplate;
        private string _resourceType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Specifies a unique, case-sensitive identifier that you provide to ensure the idempotency
        /// of the request. This lets you safely retry the request without accidentally performing
        /// the same operation a second time. Passing the same value to a later call to an operation
        /// requires that you also pass the same value for all other parameters. We recommend
        /// that you use a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID
        /// type of value.</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide this value, then Amazon Web Services generates a random one for
        /// you.
        /// </para>
        ///  
        /// <para>
        /// If you retry the operation with the same <c>ClientToken</c>, but with different parameters,
        /// the retry fails with an <c>IdempotentParameterMismatch</c> error.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of the customer managed permission. The name must be unique within
        /// the Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyTemplate. 
        /// <para>
        /// A string in JSON format string that contains the following elements of a resource-based
        /// policy:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Effect</b>: must be set to <c>ALLOW</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Action</b>: specifies the actions that are allowed by this customer managed permission.
        /// The list must contain only actions that are supported by the specified resource type.
        /// For a list of all actions supported by each resource type, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/reference_policies_actions-resources-contextkeys.html">Actions,
        /// resources, and condition keys for Amazon Web Services services</a> in the <i>Identity
        /// and Access Management User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Condition</b>: (optional) specifies conditional parameters that must evaluate
        /// to true when a user attempts an action for that action to be allowed. For more information
        /// about the Condition element, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_condition.html">IAM
        /// policies: Condition element</a> in the <i>Identity and Access Management User Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This template can't include either the <c>Resource</c> or <c>Principal</c> elements.
        /// Those are both filled in by RAM when it instantiates the resource-based policy on
        /// each resource shared using this managed permission. The <c>Resource</c> comes from
        /// the ARN of the specific resource that you are sharing. The <c>Principal</c> comes
        /// from the list of identities added to the resource share.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyTemplate
        {
            get { return this._policyTemplate; }
            set { this._policyTemplate = value; }
        }

        // Check to see if PolicyTemplate property is set
        internal bool IsSetPolicyTemplate()
        {
            return this._policyTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies the name of the resource type that this customer managed permission applies
        /// to.
        /// </para>
        ///  
        /// <para>
        /// The format is <c> <i>&lt;service-code&gt;</i>:<i>&lt;resource-type&gt;</i> </c> and
        /// is not case sensitive. For example, to specify an Amazon EC2 Subnet, you can use the
        /// string <c>ec2:subnet</c>. To see the list of valid values for this parameter, query
        /// the <a>ListResourceTypes</a> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies a list of one or more tag key and value pairs to attach to the permission.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}