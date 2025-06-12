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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A logical operator that allows multiple filter conditions to be joined for more complex
    /// comparisons of Storage Lens group data.
    /// </summary>
    public partial class StorageLensGroupAndOperator
    {
        private List<string> _matchAnyPrefix = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _matchAnySuffix = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<S3Tag> _matchAnyTag = AWSConfigs.InitializeCollections ? new List<S3Tag>() : null;
        private MatchObjectAge _matchObjectAge;
        private MatchObjectSize _matchObjectSize;

        /// <summary>
        /// Gets and sets the property MatchAnyPrefix. 
        /// <para>
        ///  Contains a list of prefixes. At least one prefix must be specified. Up to 10 prefixes
        /// are allowed. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchAnyPrefix
        {
            get { return this._matchAnyPrefix; }
            set { this._matchAnyPrefix = value; }
        }

        // Check to see if MatchAnyPrefix property is set
        internal bool IsSetMatchAnyPrefix()
        {
            return this._matchAnyPrefix != null && (this._matchAnyPrefix.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MatchAnySuffix. 
        /// <para>
        ///  Contains a list of suffixes. At least one suffix must be specified. Up to 10 suffixes
        /// are allowed. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchAnySuffix
        {
            get { return this._matchAnySuffix; }
            set { this._matchAnySuffix = value; }
        }

        // Check to see if MatchAnySuffix property is set
        internal bool IsSetMatchAnySuffix()
        {
            return this._matchAnySuffix != null && (this._matchAnySuffix.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MatchAnyTag. 
        /// <para>
        ///  Contains the list of object tags. At least one object tag must be specified. Up to
        /// 10 object tags are allowed. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Tag> MatchAnyTag
        {
            get { return this._matchAnyTag; }
            set { this._matchAnyTag = value; }
        }

        // Check to see if MatchAnyTag property is set
        internal bool IsSetMatchAnyTag()
        {
            return this._matchAnyTag != null && (this._matchAnyTag.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MatchObjectAge. 
        /// <para>
        ///  Contains <c>DaysGreaterThan</c> and <c>DaysLessThan</c> to define the object age
        /// range (minimum and maximum number of days). 
        /// </para>
        /// </summary>
        public MatchObjectAge MatchObjectAge
        {
            get { return this._matchObjectAge; }
            set { this._matchObjectAge = value; }
        }

        // Check to see if MatchObjectAge property is set
        internal bool IsSetMatchObjectAge()
        {
            return this._matchObjectAge != null;
        }

        /// <summary>
        /// Gets and sets the property MatchObjectSize. 
        /// <para>
        ///  Contains <c>BytesGreaterThan</c> and <c>BytesLessThan</c> to define the object size
        /// range (minimum and maximum number of Bytes). 
        /// </para>
        /// </summary>
        public MatchObjectSize MatchObjectSize
        {
            get { return this._matchObjectSize; }
            set { this._matchObjectSize = value; }
        }

        // Check to see if MatchObjectSize property is set
        internal bool IsSetMatchObjectSize()
        {
            return this._matchObjectSize != null;
        }

    }
}