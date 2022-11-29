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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAwsLogSource operation.
    /// Adds a natively-supported Amazon Web Services service as a Security Lake source. Enables
    /// source types for member accounts in required Regions, based on specified parameters.
    /// You can choose any source type in any Region for accounts that are either part of
    /// a trusted organization or standalone accounts. At least one of the three dimensions
    /// is a mandatory input to this API. However, any combination of the three dimensions
    /// can be supplied to this API. 
    /// 
    ///  
    /// <para>
    /// By default, dimension refers to the entire set. When you don't provide a dimension,
    /// Security Lake assumes that the missing dimension refers to the entire set. This is
    /// overridden when you supply any one of the inputs. For instance, when members is not
    /// specified, the API disables all Security Lake member accounts for sources. Similarly,
    /// when Regions are not specified, Security Lake is disabled for all the Regions where
    /// Security Lake is available as a service.
    /// </para>
    ///  
    /// <para>
    /// You can use this API only to enable a natively-supported Amazon Web Services services
    /// as a source. Use <code>CreateCustomLogSource</code> to enable data collection from
    /// a custom source. 
    /// </para>
    /// </summary>
    public partial class CreateAwsLogSourceRequest : AmazonSecurityLakeRequest
    {
        private Dictionary<string, Dictionary<string, List<string>>> _enableAllDimensions = new Dictionary<string, Dictionary<string, List<string>>>();
        private List<string> _enableSingleDimension = new List<string>();
        private Dictionary<string, List<string>> _enableTwoDimensions = new Dictionary<string, List<string>>();
        private List<string> _inputOrder = new List<string>();

        /// <summary>
        /// Gets and sets the property EnableAllDimensions. 
        /// <para>
        /// Enables specific sources in all Regions and source types.
        /// </para>
        /// </summary>
        public Dictionary<string, Dictionary<string, List<string>>> EnableAllDimensions
        {
            get { return this._enableAllDimensions; }
            set { this._enableAllDimensions = value; }
        }

        // Check to see if EnableAllDimensions property is set
        internal bool IsSetEnableAllDimensions()
        {
            return this._enableAllDimensions != null && this._enableAllDimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnableSingleDimension. 
        /// <para>
        /// Enables all sources in specific accounts or Regions.
        /// </para>
        /// </summary>
        public List<string> EnableSingleDimension
        {
            get { return this._enableSingleDimension; }
            set { this._enableSingleDimension = value; }
        }

        // Check to see if EnableSingleDimension property is set
        internal bool IsSetEnableSingleDimension()
        {
            return this._enableSingleDimension != null && this._enableSingleDimension.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnableTwoDimensions. 
        /// <para>
        /// Enables specific service sources in specific accounts or Regions.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> EnableTwoDimensions
        {
            get { return this._enableTwoDimensions; }
            set { this._enableTwoDimensions = value; }
        }

        // Check to see if EnableTwoDimensions property is set
        internal bool IsSetEnableTwoDimensions()
        {
            return this._enableTwoDimensions != null && this._enableTwoDimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputOrder. 
        /// <para>
        /// Specifies the input order to enable dimensions in Security Lake, namely region, source
        /// type, and member account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> InputOrder
        {
            get { return this._inputOrder; }
            set { this._inputOrder = value; }
        }

        // Check to see if InputOrder property is set
        internal bool IsSetInputOrder()
        {
            return this._inputOrder != null && this._inputOrder.Count > 0; 
        }

    }
}