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
 * Do not modify this file. This file is generated from the elementalinference-2018-11-14.normal.json service model.
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
namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Container for the parameters to the GetFixture operation.
    /// Retrieves information about the specified fixture (a sports event, such as a specific
    /// basketball game). You obtain a fixtureId from SearchFixtures, or from the clipping
    /// output of a feed.
    /// </summary>
    public partial class GetFixtureRequest : AmazonElementalInferenceRequest
    {
        private string _fixtureId;

        /// <summary>
        /// Gets and sets the property FixtureId. 
        /// <para>
        /// The ID of the fixture to retrieve, as returned by SearchFixtures.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string FixtureId
        {
            get { return this._fixtureId; }
            set { this._fixtureId = value; }
        }

        // Check to see if FixtureId property is set
        internal bool IsSetFixtureId()
        {
            return this._fixtureId != null;
        }

    }
}