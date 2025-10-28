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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Represents a logical grouping of services based on shared attributes or characteristics.
    /// </summary>
    public partial class ServiceGroup
    {
        private string _groupIdentifier;
        private string _groupName;
        private string _groupSource;
        private string _groupValue;

        /// <summary>
        /// Gets and sets the property GroupIdentifier. 
        /// <para>
        /// A unique identifier for the group within the grouping configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string GroupIdentifier
        {
            get { return this._groupIdentifier; }
            set { this._groupIdentifier = value; }
        }

        // Check to see if GroupIdentifier property is set
        internal bool IsSetGroupIdentifier()
        {
            return this._groupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the group, such as "Environment", "Team", or "Application".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property GroupSource. 
        /// <para>
        /// The source of the grouping information, such as "Tag", "Attribute", or "Manual".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string GroupSource
        {
            get { return this._groupSource; }
            set { this._groupSource = value; }
        }

        // Check to see if GroupSource property is set
        internal bool IsSetGroupSource()
        {
            return this._groupSource != null;
        }

        /// <summary>
        /// Gets and sets the property GroupValue. 
        /// <para>
        /// The specific value for this group, such as "Production", "TeamA", or "WebApp".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string GroupValue
        {
            get { return this._groupValue; }
            set { this._groupValue = value; }
        }

        // Check to see if GroupValue property is set
        internal bool IsSetGroupValue()
        {
            return this._groupValue != null;
        }

    }
}