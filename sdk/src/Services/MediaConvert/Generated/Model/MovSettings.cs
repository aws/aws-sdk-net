/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for MOV Container.
    /// </summary>
    public partial class MovSettings
    {
        private MovClapAtom _clapAtom;
        private MovCslgAtom _cslgAtom;
        private MovMpeg2FourCCControl _mpeg2FourCCControl;
        private MovPaddingControl _paddingControl;
        private MovReference _reference;

        /// <summary>
        /// Gets and sets the property ClapAtom.
        /// </summary>
        public MovClapAtom ClapAtom
        {
            get { return this._clapAtom; }
            set { this._clapAtom = value; }
        }

        // Check to see if ClapAtom property is set
        internal bool IsSetClapAtom()
        {
            return this._clapAtom != null;
        }

        /// <summary>
        /// Gets and sets the property CslgAtom.
        /// </summary>
        public MovCslgAtom CslgAtom
        {
            get { return this._cslgAtom; }
            set { this._cslgAtom = value; }
        }

        // Check to see if CslgAtom property is set
        internal bool IsSetCslgAtom()
        {
            return this._cslgAtom != null;
        }

        /// <summary>
        /// Gets and sets the property Mpeg2FourCCControl.
        /// </summary>
        public MovMpeg2FourCCControl Mpeg2FourCCControl
        {
            get { return this._mpeg2FourCCControl; }
            set { this._mpeg2FourCCControl = value; }
        }

        // Check to see if Mpeg2FourCCControl property is set
        internal bool IsSetMpeg2FourCCControl()
        {
            return this._mpeg2FourCCControl != null;
        }

        /// <summary>
        /// Gets and sets the property PaddingControl.
        /// </summary>
        public MovPaddingControl PaddingControl
        {
            get { return this._paddingControl; }
            set { this._paddingControl = value; }
        }

        // Check to see if PaddingControl property is set
        internal bool IsSetPaddingControl()
        {
            return this._paddingControl != null;
        }

        /// <summary>
        /// Gets and sets the property Reference.
        /// </summary>
        public MovReference Reference
        {
            get { return this._reference; }
            set { this._reference = value; }
        }

        // Check to see if Reference property is set
        internal bool IsSetReference()
        {
            return this._reference != null;
        }

    }
}