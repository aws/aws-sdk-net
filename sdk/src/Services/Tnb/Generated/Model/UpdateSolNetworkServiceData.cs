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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
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
namespace Amazon.Tnb.Model
{
    /// <summary>
    /// Information parameters and/or the configurable properties for a network descriptor
    /// used for update.
    /// </summary>
    public partial class UpdateSolNetworkServiceData
    {
        private Amazon.Runtime.Documents.Document _additionalParamsForNs;
        private string _nsdInfoId;

        /// <summary>
        /// Gets and sets the property AdditionalParamsForNs. 
        /// <para>
        /// Values for the configurable properties declared in the network service descriptor.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document AdditionalParamsForNs
        {
            get { return this._additionalParamsForNs; }
            set { this._additionalParamsForNs = value; }
        }

        // Check to see if AdditionalParamsForNs property is set
        internal bool IsSetAdditionalParamsForNs()
        {
            return !this._additionalParamsForNs.IsNull();
        }

        /// <summary>
        /// Gets and sets the property NsdInfoId. 
        /// <para>
        /// ID of the network service descriptor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsdInfoId
        {
            get { return this._nsdInfoId; }
            set { this._nsdInfoId = value; }
        }

        // Check to see if NsdInfoId property is set
        internal bool IsSetNsdInfoId()
        {
            return this._nsdInfoId != null;
        }

    }
}