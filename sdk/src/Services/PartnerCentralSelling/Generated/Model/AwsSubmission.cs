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
    /// Indicates the level of AWS involvement in the opportunity. This field helps track
    /// AWS participation throughout the engagement, such as providing technical support,
    /// deal assistance, and sales support.
    /// </summary>
    public partial class AwsSubmission
    {
        private SalesInvolvementType _involvementType;
        private Visibility _visibility;

        /// <summary>
        /// Gets and sets the property InvolvementType. 
        /// <para>
        /// Specifies the type of AWS involvement in the opportunity, such as coselling, deal
        /// support, or technical consultation. This helps categorize the nature of AWS participation.
        /// </para>
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
        /// Determines who can view AWS involvement in the opportunity. Typically, this field
        /// is set to <c>Full</c> for most cases, but it may be restricted based on special program
        /// requirements or confidentiality needs.
        /// </para>
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