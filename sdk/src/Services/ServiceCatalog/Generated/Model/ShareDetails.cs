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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Information about the portfolio share operation.
    /// </summary>
    public partial class ShareDetails
    {
        private List<ShareError> _shareErrors = new List<ShareError>();
        private List<string> _successfulShares = new List<string>();

        /// <summary>
        /// Gets and sets the property ShareErrors. 
        /// <para>
        /// List of errors.
        /// </para>
        /// </summary>
        public List<ShareError> ShareErrors
        {
            get { return this._shareErrors; }
            set { this._shareErrors = value; }
        }

        // Check to see if ShareErrors property is set
        internal bool IsSetShareErrors()
        {
            return this._shareErrors != null && this._shareErrors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulShares. 
        /// <para>
        /// List of accounts for whom the operation succeeded.
        /// </para>
        /// </summary>
        public List<string> SuccessfulShares
        {
            get { return this._successfulShares; }
            set { this._successfulShares = value; }
        }

        // Check to see if SuccessfulShares property is set
        internal bool IsSetSuccessfulShares()
        {
            return this._successfulShares != null && this._successfulShares.Count > 0; 
        }

    }
}