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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLocation operation.
    /// Creates a custom location for use in an Anywhere fleet.
    /// </summary>
    public partial class CreateLocationRequest : AmazonGameLiftRequest
    {
        private string _locationName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property LocationName. 
        /// <para>
        /// A descriptive name for the custom location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=64)]
        public string LocationName
        {
            get { return this._locationName; }
            set { this._locationName = value; }
        }

        // Check to see if LocationName property is set
        internal bool IsSetLocationName()
        {
            return this._locationName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of labels to assign to the new matchmaking configuration resource. Tags are
        /// developer-defined key-value pairs. Tagging Amazon Web Services resources are useful
        /// for resource management, access management and cost allocation. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html"> Tagging
        /// Amazon Web Services Resources</a> in the <i>Amazon Web Services General Rareference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}