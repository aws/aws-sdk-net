/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// This is the response object from the DescribeLags operation.
    /// </summary>
    public partial class DescribeLagsResponse : AmazonWebServiceResponse
    {
        private List<Lag> _lags = new List<Lag>();

        /// <summary>
        /// Gets and sets the property Lags. 
        /// <para>
        /// The LAGs.
        /// </para>
        /// </summary>
        public List<Lag> Lags
        {
            get { return this._lags; }
            set { this._lags = value; }
        }

        // Check to see if Lags property is set
        internal bool IsSetLags()
        {
            return this._lags != null && this._lags.Count > 0; 
        }

    }
}