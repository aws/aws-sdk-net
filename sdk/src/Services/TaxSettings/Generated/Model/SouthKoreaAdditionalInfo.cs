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
    /// Additional tax information associated with your TRN in South Korea.
    /// </summary>
    public partial class SouthKoreaAdditionalInfo
    {
        private string _businessRepresentativeName;
        private string _itemOfBusiness;
        private string _lineOfBusiness;

        /// <summary>
        /// Gets and sets the property BusinessRepresentativeName. 
        /// <para>
        /// The business legal name based on the most recently uploaded tax registration certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string BusinessRepresentativeName
        {
            get { return this._businessRepresentativeName; }
            set { this._businessRepresentativeName = value; }
        }

        // Check to see if BusinessRepresentativeName property is set
        internal bool IsSetBusinessRepresentativeName()
        {
            return this._businessRepresentativeName != null;
        }

        /// <summary>
        /// Gets and sets the property ItemOfBusiness. 
        /// <para>
        /// Item of business based on the most recently uploaded tax registration certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ItemOfBusiness
        {
            get { return this._itemOfBusiness; }
            set { this._itemOfBusiness = value; }
        }

        // Check to see if ItemOfBusiness property is set
        internal bool IsSetItemOfBusiness()
        {
            return this._itemOfBusiness != null;
        }

        /// <summary>
        /// Gets and sets the property LineOfBusiness. 
        /// <para>
        /// Line of business based on the most recently uploaded tax registration certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string LineOfBusiness
        {
            get { return this._lineOfBusiness; }
            set { this._lineOfBusiness = value; }
        }

        // Check to see if LineOfBusiness property is set
        internal bool IsSetLineOfBusiness()
        {
            return this._lineOfBusiness != null;
        }

    }
}