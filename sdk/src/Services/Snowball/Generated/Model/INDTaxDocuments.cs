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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// The tax documents required in Amazon Web Services Region in India.
    /// </summary>
    public partial class INDTaxDocuments
    {
        private string _gstin;

        /// <summary>
        /// Gets and sets the property GSTIN. 
        /// <para>
        /// The Goods and Services Tax (GST) documents required in Amazon Web Services Region
        /// in India.
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=15)]
        public string GSTIN
        {
            get { return this._gstin; }
            set { this._gstin = value; }
        }

        // Check to see if GSTIN property is set
        internal bool IsSetGSTIN()
        {
            return this._gstin != null;
        }

    }
}