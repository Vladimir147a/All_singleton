public class SingeltoneKukush {
private static SingeltoneKukush instance;

private SingeltoneKukush() {
}
public static SingeltoneKukush getInstance() {
if (instance == null)  {
instance = new SingeltoneKukush();
}
return instance;
}
}