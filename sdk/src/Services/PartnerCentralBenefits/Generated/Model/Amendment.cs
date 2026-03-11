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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
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
namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// Represents a specific change to be made to a benefit application field.
    /// </summary>
    public partial class Amendment
    {
        private string _fieldPath;
        private string _newValue;

        /// <summary>
        /// Gets and sets the property FieldPath. 
        /// <para>
        /// The JSON path or field identifier specifying which field in the benefit application
        /// to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FieldPath
        {
            get { return this._fieldPath; }
            set { this._fieldPath = value; }
        }

        // Check to see if FieldPath property is set
        internal bool IsSetFieldPath()
        {
            return this._fieldPath != null;
        }

        /// <summary>
        /// Gets and sets the property NewValue. 
        /// <para>
        /// The new value to set for the specified field in the benefit application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NewValue
        {
            get { return this._newValue; }
            set { this._newValue = value; }
        }

        // Check to see if NewValue property is set
        internal bool IsSetNewValue()
        {
            return this._newValue != null;
        }

    }
}