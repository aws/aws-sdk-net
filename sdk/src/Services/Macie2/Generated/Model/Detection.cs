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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about a type of sensitive data that Amazon Macie found in an
    /// S3 bucket while performing automated sensitive data discovery for the bucket. The
    /// information also specifies the custom data identifier or managed data identifier that
    /// detected the data. This information is available only if automated sensitive data
    /// discovery is currently enabled for your account.
    /// </summary>
    public partial class Detection
    {
        private string _arn;
        private long? _count;
        private string _id;
        private string _name;
        private bool? _suppressed;
        private DataIdentifierType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// If the sensitive data was detected by a custom data identifier, the Amazon Resource
        /// Name (ARN) of the custom data identifier that detected the data. Otherwise, this value
        /// is null.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The total number of occurrences of the sensitive data.
        /// </para>
        /// </summary>
        public long Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the custom data identifier or managed data identifier that
        /// detected the sensitive data. For additional details about a specified managed data
        /// identifier, see <a href="https://docs.aws.amazon.com/macie/latest/user/managed-data-identifiers.html">Using
        /// managed data identifiers</a> in the <i>Amazon Macie User Guide</i>.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom data identifier or managed data identifier that detected the
        /// sensitive data. For a managed data identifier, this value is the same as the unique
        /// identifier (id).
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Suppressed. 
        /// <para>
        /// Specifies whether occurrences of this type of sensitive data are excluded (true) or
        /// included (false) in the bucket's sensitivity score.
        /// </para>
        /// </summary>
        public bool Suppressed
        {
            get { return this._suppressed.GetValueOrDefault(); }
            set { this._suppressed = value; }
        }

        // Check to see if Suppressed property is set
        internal bool IsSetSuppressed()
        {
            return this._suppressed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of data identifier that detected the sensitive data. Possible values are:
        /// CUSTOM, for a custom data identifier; and, MANAGED, for a managed data identifier.
        /// </para>
        /// </summary>
        public DataIdentifierType Type
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