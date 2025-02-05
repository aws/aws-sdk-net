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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Container for the parameters to the SubmitOpportunity operation.
    /// Use this action to submit an Opportunity that was previously created by partner for
    /// AWS review. After you perform this action, the Opportunity becomes non-editable until
    /// it is reviewed by AWS and has <c> LifeCycle.ReviewStatus </c> as either <c>Approved</c>
    /// or <c>Action Required</c>.
    /// </summary>
    public partial class SubmitOpportunityRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _identifier;
        private SalesInvolvementType _involvementType;
        private Visibility _visibility;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog related to the request. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS: Submits the opportunity request from the production AWS environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sandbox: Submits the opportunity request from a sandbox environment used for testing
        /// or development purposes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the Opportunity previously created by partner and needs to be submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property InvolvementType. 
        /// <para>
        /// Specifies the level of AWS sellers' involvement on the opportunity. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Co-sell</c>: Indicates the user wants to co-sell with AWS. Share the opportunity
        /// with AWS to receive deal assistance and support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>For Visibility Only</c>: Indicates that the user does not need support from AWS
        /// Sales Rep. Share this opportunity with AWS for visibility only, you will not receive
        /// deal assistance and support.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public SalesInvolvementType InvolvementType
        {
            get { return this._involvementType; }
            set { this._involvementType = value; }
        }

        // Check to see if InvolvementType property is set
        internal bool IsSetInvolvementType()
        {
            return this._involvementType != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// Determines whether to restrict visibility of the opportunity from AWS sales. Default
        /// value is Full. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Full</c>: The opportunity is fully visible to AWS sales.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Limited</c>: The opportunity has restricted visibility to AWS sales.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Visibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}