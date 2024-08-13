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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Provides UserID metadata along with the confidence in the match of this UserID with
    /// the input face.
    /// </summary>
    public partial class UserMatch
    {
        private float? _similarity;
        private MatchedUser _user;

        /// <summary>
        /// Gets and sets the property Similarity. 
        /// <para>
        ///  Describes the UserID metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? Similarity
        {
            get { return this._similarity; }
            set { this._similarity = value; }
        }

        // Check to see if Similarity property is set
        internal bool IsSetSimilarity()
        {
            return this._similarity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        ///  Confidence in the match of this UserID with the input face. 
        /// </para>
        /// </summary>
        public MatchedUser User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

    }
}