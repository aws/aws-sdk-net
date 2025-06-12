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
    /// The criteria used to filter the machine learning transforms.
    /// </summary>
    public partial class TransformFilterCriteria
    {
        private DateTime? _createdAfter;
        private DateTime? _createdBefore;
        private string _glueVersion;
        private DateTime? _lastModifiedAfter;
        private DateTime? _lastModifiedBefore;
        private string _name;
        private List<SchemaColumn> _schema = AWSConfigs.InitializeCollections ? new List<SchemaColumn>() : null;
        private TransformStatusType _status;
        private TransformType _transformType;

        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// The time and date after which the transforms were created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter
        {
            get { return this._createdAfter; }
            set { this._createdAfter = value; }
        }

        // Check to see if CreatedAfter property is set
        internal bool IsSetCreatedAfter()
        {
            return this._createdAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// The time and date before which the transforms were created.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore
        {
            get { return this._createdBefore; }
            set { this._createdBefore = value; }
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this._createdBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlueVersion. 
        /// <para>
        /// This value determines which version of Glue this machine learning transform is compatible
        /// with. Glue 1.0 is recommended for most customers. If the value is not set, the Glue
        /// compatibility defaults to Glue 0.9. For more information, see <a href="https://docs.aws.amazon.com/glue/latest/dg/release-notes.html#release-notes-versions">Glue
        /// Versions</a> in the developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string GlueVersion
        {
            get { return this._glueVersion; }
            set { this._glueVersion = value; }
        }

        // Check to see if GlueVersion property is set
        internal bool IsSetGlueVersion()
        {
            return this._glueVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedAfter. 
        /// <para>
        /// Filter on transforms last modified after this date.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedAfter
        {
            get { return this._lastModifiedAfter; }
            set { this._lastModifiedAfter = value; }
        }

        // Check to see if LastModifiedAfter property is set
        internal bool IsSetLastModifiedAfter()
        {
            return this._lastModifiedAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBefore. 
        /// <para>
        /// Filter on transforms last modified before this date.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedBefore
        {
            get { return this._lastModifiedBefore; }
            set { this._lastModifiedBefore = value; }
        }

        // Check to see if LastModifiedBefore property is set
        internal bool IsSetLastModifiedBefore()
        {
            return this._lastModifiedBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique transform name that is used to filter the machine learning transforms.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Schema. 
        /// <para>
        /// Filters on datasets with a specific schema. The <c>Map&lt;Column, Type&gt;</c> object
        /// is an array of key-value pairs representing the schema this transform accepts, where
        /// <c>Column</c> is the name of a column, and <c>Type</c> is the type of the data such
        /// as an integer or string. Has an upper bound of 100 columns.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<SchemaColumn> Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null && (this._schema.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filters the list of machine learning transforms by the last known status of the transforms
        /// (to indicate whether a transform can be used or not). One of "NOT_READY", "READY",
        /// or "DELETING".
        /// </para>
        /// </summary>
        public TransformStatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TransformType. 
        /// <para>
        /// The type of machine learning transform that is used to filter the machine learning
        /// transforms.
        /// </para>
        /// </summary>
        public TransformType TransformType
        {
            get { return this._transformType; }
            set { this._transformType = value; }
        }

        // Check to see if TransformType property is set
        internal bool IsSetTransformType()
        {
            return this._transformType != null;
        }

    }
}