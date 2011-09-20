
package test.org.bn.coders.test_asn;
//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

import org.bn.*;
import org.bn.annotations.*;
import org.bn.annotations.constraints.*;
import org.bn.coders.*;
import org.bn.types.*;




    @ASN1PreparedElement
    @ASN1BoxedType ( name = "Set5" )
    public class Set5 implements IASN1PreparedElement {
                
        
@ASN1SequenceOf( name = "Set5", isSetOf = true ) 

    
        @ASN1Element ( name = "Set5", isOptional =  false , hasTag =  true, tag = 127, 
        tagClass =  TagClass.Application  , hasDefaultValue =  false  )
    
        private java.util.Collection<Set3>   value;        

        
        
        public Set5 () {
        }
        
        
        
        public void setValue(java.util.Collection<Set3>  value) {
            this.value = value;
        }
        
        
        
        public java.util.Collection<Set3>  getValue() {
            return this.value;
        }            
        

	    public void initWithDefaults() {
	    }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(Set5.class);
        public IASN1PreparedElementData getPreparedData() {
            return preparedData;
        }

            
    }
            