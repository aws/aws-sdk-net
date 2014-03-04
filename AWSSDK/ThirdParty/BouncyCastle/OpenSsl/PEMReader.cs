/*
 * Copyright (c) 2000 - 2011 The Legion Of The Bouncy Castle (http://www.bouncycastle.org)
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this 
 * software and associated documentation files (the "Software"), to deal in the 
 * Software without restriction, including without limitation the rights to use, 
 * copy, modify, merge, publish, distribute, sublicense, and/or sell copies of 
 * the Software, and to permit persons to whom the Software is furnished to do so, 
 * subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies 
 * or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
 * PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE 
 * FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR 
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
 * DEALINGS IN THE SOFTWARE.
 * 
 */
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Security.Cryptography;

using ThirdParty.BouncyCastle.Asn1;
using ThirdParty.BouncyCastle.Utilities;
using ThirdParty.BouncyCastle.Utilities.IO.Pem;

namespace ThirdParty.BouncyCastle.OpenSsl
{

    public class PemReader
		: ThirdParty.BouncyCastle.Utilities.IO.Pem.PemReader
	{

        public PemReader(
			TextReader		reader)
			: base(reader)
		{
		}

        public RSAParameters ReadPrivatekey()
        {
            PemObject pemObject = ReadPemObject();

            Debug.Assert(pemObject.Type.EndsWith("PRIVATE KEY"));

            string type = pemObject.Type.Substring(0, pemObject.Type.Length - "PRIVATE KEY".Length).Trim();
            byte[] keyBytes = pemObject.Content;
            Asn1Sequence seq = (Asn1Sequence)Asn1Object.FromByteArray(keyBytes);

            if (seq.Count != 9)
                throw new ApplicationException("malformed sequence in RSA private key");

            return convertSequenceToRSAParameters(seq);
        }

        RSAParameters convertSequenceToRSAParameters(Asn1Sequence seq)
        {
            var rsaParams = new RSAParameters();

            rsaParams.Modulus = ((DerInteger)seq[1]).Value.ToByteArrayUnsigned();
            rsaParams.Exponent = ((DerInteger)seq[2]).Value.ToByteArrayUnsigned();
            rsaParams.D = ((DerInteger)seq[3]).Value.ToByteArrayUnsigned();
            rsaParams.P = ((DerInteger)seq[4]).Value.ToByteArrayUnsigned();
            rsaParams.Q = ((DerInteger)seq[5]).Value.ToByteArrayUnsigned();
            rsaParams.DP = ((DerInteger)seq[6]).Value.ToByteArrayUnsigned();
            rsaParams.DQ = ((DerInteger)seq[7]).Value.ToByteArrayUnsigned();
            rsaParams.InverseQ = ((DerInteger)seq[8]).Value.ToByteArrayUnsigned();


            return rsaParams;
        }


	}
}
