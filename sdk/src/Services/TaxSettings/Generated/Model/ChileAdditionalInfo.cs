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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
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
namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// Additional tax information associated with your TRN in Chile.
    /// </summary>
    public partial class ChileAdditionalInfo
    {
        private string _businessActivity;
        private ChileDocumentType _documentType;

        /// <summary>
        /// Gets and sets the property BusinessActivity. 
        /// <para>
        ///  The business activity of the taxpayer in Chile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string BusinessActivity
        {
            get { return this._businessActivity; }
            set { this._businessActivity = value; }
        }

        // Check to see if BusinessActivity property is set
        internal bool IsSetBusinessActivity()
        {
            return this._businessActivity != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentType. 
        /// <para>
        ///  The type of tax document. For Chile, this can be <c>Invoice</c> or <c>Receipt</c>.
        /// </para>
        /// </summary>
        public ChileDocumentType DocumentType
        {
            get { return this._documentType; }
            set { this._documentType = value; }
        }

        // Check to see if DocumentType property is set
        internal bool IsSetDocumentType()
        {
            return this._documentType != null;
        }

    }
}