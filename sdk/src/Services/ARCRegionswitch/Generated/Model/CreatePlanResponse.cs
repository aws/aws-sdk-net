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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// This is the response object from the CreatePlan operation.
    /// </summary>
    public partial class CreatePlanResponse : AmazonWebServiceResponse
    {
        private Plan _plan;

        /// <summary>
        /// Gets and sets the property Plan. 
        /// <para>
        /// The details of the created Region switch plan.
        /// </para>
        /// </summary>
        public Plan Plan
        {
            get { return this._plan; }
            set { this._plan = value; }
        }

        // Check to see if Plan property is set
        internal bool IsSetPlan()
        {
            return this._plan != null;
        }

    }
}