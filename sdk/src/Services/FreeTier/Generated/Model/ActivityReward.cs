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
 * Do not modify this file. This file is generated from the freetier-2023-09-07.normal.json service model.
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
namespace Amazon.FreeTier.Model
{
    /// <summary>
    /// The summary of the rewards granted as a result of activities completed.
    /// </summary>
    public partial class ActivityReward
    {
        private MonetaryAmount _credit;

        /// <summary>
        /// Gets and sets the property Credit. 
        /// <para>
        ///  The credits gained by activity rewards. 
        /// </para>
        /// </summary>
        public MonetaryAmount Credit
        {
            get { return this._credit; }
            set { this._credit = value; }
        }

        // Check to see if Credit property is set
        internal bool IsSetCredit()
        {
            return this._credit != null;
        }

    }
}