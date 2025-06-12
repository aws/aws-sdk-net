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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDevEndpoint operation.
    /// Updates a specified development endpoint.
    /// </summary>
    public partial class UpdateDevEndpointRequest : AmazonGlueRequest
    {
        private Dictionary<string, string> _addArguments = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _addPublicKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DevEndpointCustomLibraries _customLibraries;
        private List<string> _deleteArguments = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _deletePublicKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _endpointName;
        private string _publicKey;
        private bool? _updateEtlLibraries;

        /// <summary>
        /// Gets and sets the property AddArguments. 
        /// <para>
        /// The map of arguments to add the map of arguments used to configure the <c>DevEndpoint</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid arguments are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"--enable-glue-datacatalog": ""</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can specify a version of Python support for development endpoints by using the
        /// <c>Arguments</c> parameter in the <c>CreateDevEndpoint</c> or <c>UpdateDevEndpoint</c>
        /// APIs. If no arguments are provided, the version defaults to Python 2.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> AddArguments
        {
            get { return this._addArguments; }
            set { this._addArguments = value; }
        }

        // Check to see if AddArguments property is set
        internal bool IsSetAddArguments()
        {
            return this._addArguments != null && (this._addArguments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AddPublicKeys. 
        /// <para>
        /// The list of public keys for the <c>DevEndpoint</c> to use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> AddPublicKeys
        {
            get { return this._addPublicKeys; }
            set { this._addPublicKeys = value; }
        }

        // Check to see if AddPublicKeys property is set
        internal bool IsSetAddPublicKeys()
        {
            return this._addPublicKeys != null && (this._addPublicKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomLibraries. 
        /// <para>
        /// Custom Python or Java libraries to be loaded in the <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public DevEndpointCustomLibraries CustomLibraries
        {
            get { return this._customLibraries; }
            set { this._customLibraries = value; }
        }

        // Check to see if CustomLibraries property is set
        internal bool IsSetCustomLibraries()
        {
            return this._customLibraries != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteArguments. 
        /// <para>
        /// The list of argument keys to be deleted from the map of arguments used to configure
        /// the <c>DevEndpoint</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeleteArguments
        {
            get { return this._deleteArguments; }
            set { this._deleteArguments = value; }
        }

        // Check to see if DeleteArguments property is set
        internal bool IsSetDeleteArguments()
        {
            return this._deleteArguments != null && (this._deleteArguments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeletePublicKeys. 
        /// <para>
        /// The list of public keys to be deleted from the <c>DevEndpoint</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> DeletePublicKeys
        {
            get { return this._deletePublicKeys; }
            set { this._deletePublicKeys = value; }
        }

        // Check to see if DeletePublicKeys property is set
        internal bool IsSetDeletePublicKeys()
        {
            return this._deletePublicKeys != null && (this._deletePublicKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the <c>DevEndpoint</c> to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The public key for the <c>DevEndpoint</c> to use.
        /// </para>
        /// </summary>
        public string PublicKey
        {
            get { return this._publicKey; }
            set { this._publicKey = value; }
        }

        // Check to see if PublicKey property is set
        internal bool IsSetPublicKey()
        {
            return this._publicKey != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateEtlLibraries. 
        /// <para>
        ///  <c>True</c> if the list of custom libraries to be loaded in the development endpoint
        /// needs to be updated, or <c>False</c> if otherwise.
        /// </para>
        /// </summary>
        public bool? UpdateEtlLibraries
        {
            get { return this._updateEtlLibraries; }
            set { this._updateEtlLibraries = value; }
        }

        // Check to see if UpdateEtlLibraries property is set
        internal bool IsSetUpdateEtlLibraries()
        {
            return this._updateEtlLibraries.HasValue; 
        }

    }
}