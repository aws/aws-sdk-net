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
    /// Contains the results of an autonomous prospecting job. This includes data and insights
    /// that AWS provides about a prospected customer account.
    /// </summary>
    public partial class ProspectingResult
    {
        private ProspectingResultAws _aws;

        /// <summary>
        /// Gets and sets the property Aws. 
        /// <para>
        /// Prospecting data and insights that AWS provides during the prospecting job. This includes
        /// customer details, task information, and scoring that AI generates.
        /// </para>
        /// </summary>
        public ProspectingResultAws Aws
        {
            get { return this._aws; }
            set { this._aws = value; }
        }

        // Check to see if Aws property is set
        internal bool IsSetAws()
        {
            return this._aws != null;
        }

    }
}