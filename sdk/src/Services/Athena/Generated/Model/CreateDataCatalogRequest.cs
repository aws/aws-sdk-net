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
    /// Container for the parameters to the CreateDataCatalog operation.
    /// Creates (registers) a data catalog with the specified name and properties. Catalogs
    /// created are visible to all users of the same Amazon Web Services account.
    /// 
    ///  
    /// <para>
    /// For a <c>FEDERATED</c> catalog, this API operation creates the following resources.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CFN Stack Name with a maximum length of 128 characters and prefix <c>athenafederatedcatalog-CATALOG_NAME_SANITIZED</c>
    /// with length 23 characters.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Lambda Function Name with a maximum length of 64 characters and prefix <c>athenafederatedcatalog_CATALOG_NAME_SANITIZED</c>
    /// with length 23 characters.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Glue Connection Name with a maximum length of 255 characters and a prefix <c>athenafederatedcatalog_CATALOG_NAME_SANITIZED</c>
    /// with length 23 characters. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateDataCatalogRequest : AmazonAthenaRequest
    {
        private string _description;
        private string _name;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private DataCatalogType _type;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the data catalog to be created.
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
        /// The name of the data catalog to create. The catalog name must be unique for the Amazon
        /// Web Services account and can use a maximum of 127 alphanumeric, underscore, at sign,
        /// or hyphen characters. The remainder of the length constraint of 256 is reserved for
        /// use by Athena.
        /// </para>
        ///  
        /// <para>
        /// For <c>FEDERATED</c> type the catalog name has following considerations and limits:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The catalog name allows special characters such as <c>_ , @ , \ , - </c>. These characters
        /// are replaced with a hyphen (-) when creating the CFN Stack Name and with an underscore
        /// (_) when creating the Lambda Function and Glue Connection Name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The catalog name has a theoretical limit of 128 characters. However, since we use
        /// it to create other resources that allow less characters and we prepend a prefix to
        /// it, the actual catalog name limit for <c>FEDERATED</c> catalog is 64 - 23 = 41 characters.
        /// </para>
        ///  </li> </ul>
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
        /// Specifies the Lambda function or functions to use for creating the data catalog. This
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
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// The <c>GLUE</c> type takes a catalog ID parameter and is required. The <c> <i>catalog_id</i>
        /// </c> is the account ID of the Amazon Web Services account to which the Glue Data Catalog
        /// belongs.
        /// </para>
        ///  
        /// <para>
        ///  <c>catalog-id=<i>catalog_id</i> </c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>GLUE</c> data catalog type also applies to the default <c>AwsDataCatalog</c>
        /// that already exists in your account, of which you can have only one and cannot modify.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// The <c>FEDERATED</c> data catalog type uses one of the following parameters, but not
        /// both. Use <c>connection-arn</c> for an existing Glue connection. Use <c>connection-type</c>
        /// and <c>connection-properties</c> to specify the configuration setting for a new connection.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>connection-arn:<i>&lt;glue_connection_arn_to_reuse&gt;</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>lambda-role-arn</c> (optional): The execution role to use for the Lambda function.
        /// If not provided, one is created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>connection-type:MYSQL|REDSHIFT|...., connection-properties:"<i>&lt;json_string&gt;</i>"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For <i> <c>&lt;json_string&gt;</c> </i>, use escaped JSON text, as in the following
        /// example.
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"spill_bucket\":\"my_spill\",\"spill_prefix\":\"athena-spill\",\"host\":\"abc12345.snowflakecomputing.com\",\"port\":\"1234\",\"warehouse\":\"DEV_WH\",\"database\":\"TEST\",\"schema\":\"PUBLIC\",\"SecretArn\":\"arn:aws:secretsmanager:ap-south-1:111122223333:secret:snowflake-XHb67j\"}"</c>
        /// 
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of comma separated tags to add to the data catalog that is created. All the
        /// resources that are created by the <c>CreateDataCatalog</c> API operation with <c>FEDERATED</c>
        /// type will have the tag <c>federated_athena_datacatalog="true"</c>. This includes the
        /// CFN Stack, Glue Connection, Athena DataCatalog, and all the resources created as part
        /// of the CFN Stack (Lambda Function, IAM policies/roles).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of data catalog to create: <c>LAMBDA</c> for a federated catalog, <c>GLUE</c>
        /// for an Glue Data Catalog, and <c>HIVE</c> for an external Apache Hive metastore. <c>FEDERATED</c>
        /// is a federated catalog for which Athena creates the connection and the Lambda function
        /// for you based on the parameters that you pass.
        /// </para>
        ///  
        /// <para>
        /// For <c>FEDERATED</c> type, we do not support IAM identity center.
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