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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The options that affect the scope of the response.
    /// </summary>
    public partial class ResourceTypeOption
    {
        private ImageReferenceOptionName _optionName;
        private List<string> _optionValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property OptionName. 
        /// <para>
        /// The name of the option.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>ec2:Instance</c>:
        /// </para>
        ///  
        /// <para>
        /// Specify <c>state-name</c> - The current state of the EC2 instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>ec2:LaunchTemplate</c>:
        /// </para>
        ///  
        /// <para>
        /// Specify <c>version-depth</c> - The number of launch template versions to check, starting
        /// from the most recent version.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ImageReferenceOptionName OptionName
        {
            get { return this._optionName; }
            set { this._optionName = value; }
        }

        // Check to see if OptionName property is set
        internal bool IsSetOptionName()
        {
            return this._optionName != null;
        }

        /// <summary>
        /// Gets and sets the property OptionValues. 
        /// <para>
        /// A value for the specified option.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>state-name</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Valid values: <c>pending</c> | <c>running</c> | <c>shutting-down</c> | <c>terminated</c>
        /// | <c>stopping</c> | <c>stopped</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Default: All states
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For <c>version-depth</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Valid values: Integers between <c>1</c> and <c>10000</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Default: <c>10</c> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OptionValues
        {
            get { return this._optionValues; }
            set { this._optionValues = value; }
        }

        // Check to see if OptionValues property is set
        internal bool IsSetOptionValues()
        {
            return this._optionValues != null && (this._optionValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}