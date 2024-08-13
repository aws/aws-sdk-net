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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Information about the portfolio share.
    /// </summary>
    public partial class PortfolioShareDetail
    {
        private bool? _accepted;
        private string _principalId;
        private bool? _sharePrincipals;
        private bool? _shareTagOptions;
        private DescribePortfolioShareType _type;

        /// <summary>
        /// Gets and sets the property Accepted. 
        /// <para>
        /// Indicates whether the shared portfolio is imported by the recipient account. If the
        /// recipient is in an organization node, the share is automatically imported, and the
        /// field is always set to true.
        /// </para>
        /// </summary>
        public bool? Accepted
        {
            get { return this._accepted; }
            set { this._accepted = value; }
        }

        // Check to see if Accepted property is set
        internal bool IsSetAccepted()
        {
            return this._accepted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The identifier of the recipient entity that received the portfolio share. The recipient
        /// entity can be one of the following:
        /// </para>
        ///  
        /// <para>
        /// 1. An external account.
        /// </para>
        ///  
        /// <para>
        /// 2. An organziation member account.
        /// </para>
        ///  
        /// <para>
        /// 3. An organzational unit (OU).
        /// </para>
        ///  
        /// <para>
        /// 4. The organization itself. (This shares with every account in the organization).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string PrincipalId
        {
            get { return this._principalId; }
            set { this._principalId = value; }
        }

        // Check to see if PrincipalId property is set
        internal bool IsSetPrincipalId()
        {
            return this._principalId != null;
        }

        /// <summary>
        /// Gets and sets the property SharePrincipals. 
        /// <para>
        /// Indicates if <c>Principal</c> sharing is enabled or disabled for the portfolio share.
        /// 
        /// </para>
        /// </summary>
        public bool? SharePrincipals
        {
            get { return this._sharePrincipals; }
            set { this._sharePrincipals = value; }
        }

        // Check to see if SharePrincipals property is set
        internal bool IsSetSharePrincipals()
        {
            return this._sharePrincipals.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShareTagOptions. 
        /// <para>
        /// Indicates whether TagOptions sharing is enabled or disabled for the portfolio share.
        /// </para>
        /// </summary>
        public bool? ShareTagOptions
        {
            get { return this._shareTagOptions; }
            set { this._shareTagOptions = value; }
        }

        // Check to see if ShareTagOptions property is set
        internal bool IsSetShareTagOptions()
        {
            return this._shareTagOptions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the portfolio share.
        /// </para>
        /// </summary>
        public DescribePortfolioShareType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}