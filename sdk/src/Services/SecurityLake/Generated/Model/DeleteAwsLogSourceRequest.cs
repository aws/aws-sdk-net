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
    /// Container for the parameters to the DeleteAwsLogSource operation.
    /// Removes a natively-supported Amazon Web Services service as a Amazon Security Lake
    /// source. When you remove the source, Security Lake stops collecting data from that
    /// source, and subscribers can no longer consume new data from the source. Subscribers
    /// can still consume data that Amazon Security Lake collected from the source before
    /// disablement.
    /// 
    ///  
    /// <para>
    /// You can choose any source type in any Region for accounts that are either part of
    /// a trusted organization or standalone accounts. At least one of the three dimensions
    /// is a mandatory input to this API. However, any combination of the three dimensions
    /// can be supplied to this API. 
    /// </para>
    ///  
    /// <para>
    /// By default, dimension refers to the entire set. This is overridden when you supply
    /// any one of the inputs. For instance, when members is not specified, the API disables
    /// all Security Lake member accounts for sources. Similarly, when Regions are not specified,
    /// Security Lake is disabled for all the Regions where Security Lake is available as
    /// a service.
    /// </para>
    ///  
    /// <para>
    /// You can use this API to remove a natively-supported Amazon Web Services service as
    /// a source. Use <code>DeregisterCustomData</code> to remove a custom source.
    /// </para>
    ///  
    /// <para>
    /// When you don't provide a dimension, Security Lake assumes that the missing dimension
    /// refers to the entire set. For example, if you don't provide specific accounts, the
    /// API applies to the entire set of accounts in your organization.
    /// </para>
    /// </summary>
    public partial class DeleteAwsLogSourceRequest : AmazonSecurityLakeRequest
    {
        private Dictionary<string, Dictionary<string, List<string>>> _disableAllDimensions = new Dictionary<string, Dictionary<string, List<string>>>();
        private List<string> _disableSingleDimension = new List<string>();
        private Dictionary<string, List<string>> _disableTwoDimensions = new Dictionary<string, List<string>>();
        private List<string> _inputOrder = new List<string>();

        /// <summary>
        /// Gets and sets the property DisableAllDimensions. 
        /// <para>
        /// Removes the specific Amazon Web Services sources from all Regions and source types.
        /// </para>
        /// </summary>
        public Dictionary<string, Dictionary<string, List<string>>> DisableAllDimensions
        {
            get { return this._disableAllDimensions; }
            set { this._disableAllDimensions = value; }
        }

        // Check to see if DisableAllDimensions property is set
        internal bool IsSetDisableAllDimensions()
        {
            return this._disableAllDimensions != null && this._disableAllDimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DisableSingleDimension. 
        /// <para>
        /// Removes all Amazon Web Services sources from specific accounts or Regions.
        /// </para>
        /// </summary>
        public List<string> DisableSingleDimension
        {
            get { return this._disableSingleDimension; }
            set { this._disableSingleDimension = value; }
        }

        // Check to see if DisableSingleDimension property is set
        internal bool IsSetDisableSingleDimension()
        {
            return this._disableSingleDimension != null && this._disableSingleDimension.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DisableTwoDimensions. 
        /// <para>
        /// Remove a specific Amazon Web Services source from specific accounts or Regions.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> DisableTwoDimensions
        {
            get { return this._disableTwoDimensions; }
            set { this._disableTwoDimensions = value; }
        }

        // Check to see if DisableTwoDimensions property is set
        internal bool IsSetDisableTwoDimensions()
        {
            return this._disableTwoDimensions != null && this._disableTwoDimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputOrder. 
        /// <para>
        /// This is a mandatory input. Specifies the input order to disable dimensions in Security
        /// Lake, namely Region, source type, and member. 
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