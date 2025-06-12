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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDataCatalog operation.
    /// Updates the data catalog that has the specified name.
    /// </summary>
    public partial class UpdateDataCatalogRequest : AmazonAthenaRequest
    {
        private string _description;
        private string _name;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DataCatalogType _type;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// New or modified text that describes the data catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data catalog to update. The catalog name must be unique for the Amazon
        /// Web Services account and can use a maximum of 127 alphanumeric, underscore, at sign,
        /// or hyphen characters. The remainder of the length constraint of 256 is reserved for
        /// use by Athena.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Specifies the Lambda function or functions to use for updating the data catalog. This
        /// is a mapping whose values depend on the catalog type. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the <c>HIVE</c> data catalog type, use the following syntax. The <c>metadata-function</c>
        /// parameter is required. <c>The sdk-version</c> parameter is optional and defaults to
        /// the currently supported version.
        /// </para>
        ///  
        /// <para>
        ///  <c>metadata-function=<i>lambda_arn</i>, sdk-version=<i>version_number</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>LAMBDA</c> data catalog type, use one of the following sets of required
        /// parameters, but not both.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have one Lambda function that processes metadata and another for reading the
        /// actual data, use the following syntax. Both parameters are required.
        /// </para>
        ///  
        /// <para>
        ///  <c>metadata-function=<i>lambda_arn</i>, record-function=<i>lambda_arn</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you have a composite Lambda function that processes both metadata and data, use
        /// the following syntax to specify your Lambda function.
        /// </para>
        ///  
        /// <para>
        ///  <c>function=<i>lambda_arn</i> </c> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the type of data catalog to update. Specify <c>LAMBDA</c> for a federated
        /// catalog, <c>HIVE</c> for an external hive metastore, or <c>GLUE</c> for an Glue Data
        /// Catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataCatalogType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}