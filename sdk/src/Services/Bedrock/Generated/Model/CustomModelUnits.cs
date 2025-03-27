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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// A <c>CustomModelUnit</c> (CMU) is an abstract view of the hardware utilization that
    /// Amazon Bedrock needs to host a single copy of your custom model. A model copy represents
    /// a single instance of your imported model that is ready to serve inference requests.
    /// Amazon Bedrock determines the number of custom model units that a model copy needs
    /// when you import the custom model. 
    /// 
    ///  
    /// <para>
    /// You can use <c>CustomModelUnits</c> to estimate the cost of running your custom model.
    /// For more information, see Calculate the cost of running a custom model in the Amazon
    /// Bedrock user guide. 
    /// </para>
    /// </summary>
    public partial class CustomModelUnits
    {
        private int? _customModelUnitsPerModelCopy;
        private string _customModelUnitsVersion;

        /// <summary>
        /// Gets and sets the property CustomModelUnitsPerModelCopy. 
        /// <para>
        /// The number of custom model units used to host a model copy. 
        /// </para>
        /// </summary>
        public int? CustomModelUnitsPerModelCopy
        {
            get { return this._customModelUnitsPerModelCopy; }
            set { this._customModelUnitsPerModelCopy = value; }
        }

        // Check to see if CustomModelUnitsPerModelCopy property is set
        internal bool IsSetCustomModelUnitsPerModelCopy()
        {
            return this._customModelUnitsPerModelCopy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomModelUnitsVersion. 
        /// <para>
        /// The version of the custom model unit. Use to determine the billing rate for the custom
        /// model unit.
        /// </para>
        /// </summary>
        public string CustomModelUnitsVersion
        {
            get { return this._customModelUnitsVersion; }
            set { this._customModelUnitsVersion = value; }
        }

        // Check to see if CustomModelUnitsVersion property is set
        internal bool IsSetCustomModelUnitsVersion()
        {
            return this._customModelUnitsVersion != null;
        }

    }
}