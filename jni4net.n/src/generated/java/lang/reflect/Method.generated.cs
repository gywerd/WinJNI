//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Method : global::java.lang.reflect.AccessibleObject, global::java.lang.reflect.GenericDeclaration, global::java.lang.reflect.Member {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getTypeParameters0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getModifiers1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getName2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDeclaringClass3;
        
        internal static global::net.sf.jni4net.jni.MethodId _isSynthetic4;
        
        internal static global::net.sf.jni4net.jni.MethodId _invoke5;
        
        internal static global::net.sf.jni4net.jni.MethodId _getParameterTypes6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getReturnType7;
        
        internal static global::net.sf.jni4net.jni.MethodId _toGenericString8;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDefaultValue9;
        
        internal static global::net.sf.jni4net.jni.MethodId _getExceptionTypes10;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGenericExceptionTypes11;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGenericParameterTypes12;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGenericReturnType13;
        
        internal static global::net.sf.jni4net.jni.MethodId _getParameterAnnotations14;
        
        internal static global::net.sf.jni4net.jni.MethodId _isBridge15;
        
        internal static global::net.sf.jni4net.jni.MethodId _isVarArgs16;
        
        internal static global::net.sf.jni4net.jni.FieldId _PUBLIC17;
        
        internal static global::net.sf.jni4net.jni.FieldId _DECLARED18;
        
        protected Method(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.Method.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int PUBLIC {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._PUBLIC17);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int DECLARED {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.reflect.Method.staticClass, global::java.lang.reflect.Method._DECLARED18);
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.reflect.Method.staticClass = staticClass;
            global::java.lang.reflect.Method._getTypeParameters0 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
            global::java.lang.reflect.Method._getModifiers1 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getModifiers", "()I");
            global::java.lang.reflect.Method._getName2 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getName", "()Ljava/lang/String;");
            global::java.lang.reflect.Method._getDeclaringClass3 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
            global::java.lang.reflect.Method._isSynthetic4 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "isSynthetic", "()Z");
            global::java.lang.reflect.Method._invoke5 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "invoke", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;");
            global::java.lang.reflect.Method._getParameterTypes6 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getParameterTypes", "()[Ljava/lang/Class;");
            global::java.lang.reflect.Method._getReturnType7 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getReturnType", "()Ljava/lang/Class;");
            global::java.lang.reflect.Method._toGenericString8 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "toGenericString", "()Ljava/lang/String;");
            global::java.lang.reflect.Method._getDefaultValue9 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getDefaultValue", "()Ljava/lang/Object;");
            global::java.lang.reflect.Method._getExceptionTypes10 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getExceptionTypes", "()[Ljava/lang/Class;");
            global::java.lang.reflect.Method._getGenericExceptionTypes11 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;");
            global::java.lang.reflect.Method._getGenericParameterTypes12 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;");
            global::java.lang.reflect.Method._getGenericReturnType13 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getGenericReturnType", "()Ljava/lang/reflect/Type;");
            global::java.lang.reflect.Method._getParameterAnnotations14 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;");
            global::java.lang.reflect.Method._isBridge15 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "isBridge", "()Z");
            global::java.lang.reflect.Method._isVarArgs16 = env.GetMethodID(global::java.lang.reflect.Method.staticClass, "isVarArgs", "()Z");
            global::java.lang.reflect.Method._PUBLIC17 = env.GetStaticFieldID(global::java.lang.reflect.Method.staticClass, "PUBLIC", "I");
            global::java.lang.reflect.Method._DECLARED18 = env.GetStaticFieldID(global::java.lang.reflect.Method.staticClass, "DECLARED", "I");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/TypeVariable;")]
        public virtual java.lang.reflect.TypeVariable[] getTypeParameters() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<java.lang.reflect.TypeVariable[]>(env, env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getTypeParameters0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getModifiers() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.reflect.Method._getModifiers1);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.String>(env, env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getName2));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public virtual global::java.lang.Class getDeclaringClass() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.Class>(env, env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getDeclaringClass3));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isSynthetic() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.reflect.Method._isSynthetic4);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object invoke(global::java.lang.Object par0, java.lang.Object[] par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.Object>(env, env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._invoke5, global::net.sf.jni4net.utils.Convertor.ParamC2J(env, par0), global::net.sf.jni4net.utils.Convertor.ParamC2J(env, par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/Class;")]
        public virtual java.lang.Class[] getParameterTypes() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<java.lang.Class[]>(env, env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getParameterTypes6));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public virtual global::java.lang.Class getReturnType() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.Class>(env, env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getReturnType7));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toGenericString() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.String>(env, env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._toGenericString8));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Object;")]
        public virtual global::java.lang.Object getDefaultValue() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.Object>(env, env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getDefaultValue9));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/Class;")]
        public virtual java.lang.Class[] getExceptionTypes() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<java.lang.Class[]>(env, env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getExceptionTypes10));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Type;")]
        public virtual java.lang.reflect.Type[] getGenericExceptionTypes() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<java.lang.reflect.Type[]>(env, env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getGenericExceptionTypes11));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Type;")]
        public virtual java.lang.reflect.Type[] getGenericParameterTypes() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<java.lang.reflect.Type[]>(env, env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getGenericParameterTypes12));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/Type;")]
        public virtual global::java.lang.reflect.Type getGenericReturnType() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.reflect.Type>(env, env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getGenericReturnType13));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[[Ljava/lang/annotation/Annotation;")]
        public virtual java.lang.annotation.Annotation[][] getParameterAnnotations() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<java.lang.annotation.Annotation[][]>(env, env.CallObjectMethodPtr(this, global::java.lang.reflect.Method._getParameterAnnotations14));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isBridge() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.reflect.Method._isBridge15);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isVarArgs() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.reflect.Method._isVarArgs16);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.reflect.Method(env);
            }
        }
    }
    #endregion
}
