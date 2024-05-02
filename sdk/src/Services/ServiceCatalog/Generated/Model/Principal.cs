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
    /// Information about a principal.
    /// </summary>
    public partial class Principal
    {
        private string _principalARN;
        private PrincipalType _principalType;

        /// <summary>
        /// Gets and sets the property PrincipalARN. 
        /// <para>
        /// The ARN of the principal (user, role, or group). This field allows for an ARN with
        /// no <c>accountID</c>, with or without wildcard characters if the <c>PrincipalType</c>
        /// is an <c>IAM_PATTERN</c>. 
        /// </para>
        ///  
        /// <para>
        /// For more information, review <a href="https://docs.aws.amazon.com/cli/latest/reference/servicecatalog/associate-principal-with-portfolio.html#options">associate-principal-with-portfolio</a>
        /// in the Amazon Web Services CLI Command Reference. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string PrincipalARN
        {
            get { return this._principalARN; }
            set { this._principalARN = value; }
        }

        // Check to see if PrincipalARN property is set
        internal bool IsSetPrincipalARN()
        {
            return this._principalARN != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalType. 
        /// <para>
        /// The principal type. The supported value is <c>IAM</c> if you use a fully defined ARN,
        /// or <c>IAM_PATTERN</c> if you use an ARN with no <c>accountID</c>, with or without
        /// wildcard characters. 
        /// </para>
        /// </summary>
        public PrincipalType PrincipalType
        {
            get { return this._principalType; }
            set { this._principalType = value; }
        }

        // Check to see if PrincipalType property is set
        internal bool IsSetPrincipalType()
        {
            return this._principalType != null;
        }

    }
}